using System.Security.Claims;
﻿using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration.UserSecrets;
using MidasAPI.DTOs;
using MidasAPI.DTOs.CompanyCredit;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class CompanyCreditService
{
    private readonly ICompanyCreditRepository _repository;
    private readonly IBusinessOwnerDetailRepository _businessRepository;
    private readonly ICompanyAssetRepository _companyAssetRepository;

    public CompanyCreditService(
        ICompanyCreditRepository repository, 
        IBusinessOwnerDetailRepository businessRepository, ICompanyAssetRepository companyAssetRepository
    )
    {
        _repository = repository;
        _businessRepository = businessRepository;
        _companyAssetRepository = companyAssetRepository;
    }

    public List<CompanyCreditDTO> GetCredit(int page, int pageSize, string status, string userId){
        var model = _repository
            .GetByStatus(page, pageSize, status, userId)
            .Select(cc => new CompanyCreditDTO(){
                CreditApplicationNumber = cc.CreditApplicationNumber??"-",
                BranchOffice = cc.BranchOffice.OfficeName,
                ApplicationAmount = cc.ApplicationAmount,
                ApplicationPeriod = cc.ApplicationPeriod,
                Status = cc.Status
            });

        return model.ToList();
    }
 

    public int CountData() => _repository.CountData();

    public int CountData(string customerId) => _repository.CountData(customerId);

    private string CreateCreditApplicationNumber(string branchOfficeCode, string nik)
    {
        return $"KBU-{branchOfficeCode}-{nik}-{DateTime.Now.ToString("ddMMyyyy")}";
    }

    public void InsertDraft(CompanyCreditInsertDTO dto, string userId)
    {
        var companyCredit = new CompanyCredit()
        {   
            Id = Guid.NewGuid().ToString(),
            CreditApplicationNumber = "-",
            Npwp = dto.Npwp,
            CompanyName = dto.CompanyName,
            CompanyType = dto.CompanyType,
            PlaceOfEstasblishment = dto.PlaceOfEstasblishment,
            EstablishRegistrationNumber = dto.EstablishRegistrationNumber,
            EstablishRegistrationDate = dto.EstablishRegistrationDate,
            CompanyRegistrationNumber = dto.CompanyRegistrationNumber,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            Address = dto.Address,
            CompanyOwnerId = userId,
            VillageId = dto.VillageId,
            BranchOfficeId = dto.BranchOfficeId,
            ApplicationAmount = dto.ApplicationAmount,
            ApplicationPeriod = dto.ApplicationPeriod,
            Status = ApprovalStatusConfig.DRAFT,
            EstablishRegistrationNumberFile = dto.EstablishRegistrationNumberFile,
            CompanyRegistrationNumberFile = dto.CompanyRegistrationNumberFile,
            Npwpfile = dto.Npwpfile,
            IdentityNumberFile = dto.IdentityNumberFile,
            BoardOfManagementFile = dto.BoardOfManagementFile,
            FinancialStatementFile = dto.FinancialStatementFile,
            CreatedBy = userId,
            CreatedAt = DateTime.Now
        };

        _repository.InsertDraft(companyCredit);

        foreach(var business in dto.BusinessOwnerDetails){
            var businessOwnerDetail = new BusinessOwnerDetail(){
                Id = Guid.NewGuid().ToString(),
                IdentityNumber = business.IdentityNumber,
                EmployeeIdentityNumber = business.EmployeeIdentityNumber,
                FullName = business.FullName,
                Position = business.Position,
                PhoneNumber = business.PhoneNumber,
                CompanyId = companyCredit.Id
            };

            _businessRepository.Insert(businessOwnerDetail);
        }

        foreach(var asset in dto.CompanyAssets){
            var companyAsset = new CompanyAsset(){
                Id = Guid.NewGuid().ToString(),
                Name = asset.Name,
                Value = asset.Value,
                CompanyId = companyCredit.Id
            };

            _companyAssetRepository.Insert(companyAsset);
        }
    }

    public void UpdateDraft(CompanyCreditUpdateDraftDTO dto, string userId)
    {
        var companyCredit = _repository.GetById(dto.Id);

        companyCredit.Npwp = dto.Npwp;
        companyCredit.CompanyName = dto.CompanyName;
        companyCredit.CompanyType = dto.CompanyType;
        companyCredit.PlaceOfEstasblishment = dto.PlaceOfEstasblishment;
        companyCredit.EstablishRegistrationNumber = dto.EstablishRegistrationNumber;
        companyCredit.EstablishRegistrationDate = dto.EstablishRegistrationDate;
        companyCredit.CompanyRegistrationNumber = dto.CompanyRegistrationNumber;
        companyCredit.Email = dto.Email;
        companyCredit.PhoneNumber = dto.PhoneNumber;
        companyCredit.Address = dto.Address;
        companyCredit.VillageId = dto.VillageId;
        companyCredit.BranchOfficeId = dto.BranchOfficeId;
        companyCredit.ApplicationAmount = dto.ApplicationAmount;
        companyCredit.ApplicationPeriod = dto.ApplicationPeriod;
        companyCredit.EstablishRegistrationNumberFile = dto.EstablishRegistrationNumberFile;
        companyCredit.Npwpfile = dto.Npwpfile;
        companyCredit.IdentityNumberFile = dto.IdentityNumberFile;
        companyCredit.BoardOfManagementFile = dto.BoardOfManagementFile;
        companyCredit.FinancialStatementFile = dto.FinancialStatementFile;
        companyCredit.UpdatedBy = userId;
        companyCredit.UpdatedAt = DateTime.Now;
        if (companyCredit.Status == ApprovalStatusConfig.REJECTED_FILES)
        {
            companyCredit.Status = ApprovalStatusConfig.WAITING_VERIFICATION_FILES;
        }

        _repository.UpdateDraft(companyCredit);
        _businessRepository.Delete(companyCredit.Id);
        _companyAssetRepository.Delete(companyCredit.Id);

        foreach(var business in dto.BusinessOwnerDetails){
            var businessOwnerDetail = new BusinessOwnerDetail(){
                Id = Guid.NewGuid().ToString(),
                IdentityNumber = business.IdentityNumber,
                EmployeeIdentityNumber = business.EmployeeIdentityNumber,
                FullName = business.FullName,
                Position = business.Position,
                PhoneNumber = business.PhoneNumber,
                CompanyId = companyCredit.Id
            };

            _businessRepository.Insert(businessOwnerDetail);
        }

        foreach(var asset in dto.CompanyAssets){
            var companyAsset = new CompanyAsset(){
                Id = Guid.NewGuid().ToString(),
                Name = asset.Name,
                Value = asset.Value,
                CompanyId = companyCredit.Id
            };

            _companyAssetRepository.Insert(companyAsset);
        }
    }

    public void DeleteDraft(string id, string userId)
    {
        var companyCredit = _repository.GetById(id);
        companyCredit.DeletedBy = userId;
        companyCredit.DeletedAt = DateTime.Now;

        _repository.UpdateDraft(companyCredit);
    }

    public ResponseDTO<string> ApplyCredit(string id)
    {
        var companyCredit = _repository.GetById(id);

        if (companyCredit.ApplicationAmount > companyCredit.CompanyOwner.CompanyCreditLimit)
        {
            return new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("Limit kredit tidak cukup"),
                Status = ApprovalStatusConfig.WAITING_VERIFICATION_PERSONAL_DATA
            };
        }

        companyCredit.CreditApplicationNumber = CreateCreditApplicationNumber(companyCredit.BranchOffice.OfficeCode, companyCredit.CompanyOwner.IdentityNumber);
        companyCredit.ApplicationDate = DateTime.Today;
        companyCredit.Status = ApprovalStatusConfig.WAITING_VERIFICATION_FILES;

        _repository.ApplyCredit(companyCredit);

        return new ResponseDTO<string>()
        {
            Message = ConstantConfigs.MESSAGE_PUT("ajukan kredit"),
            Status = ApprovalStatusConfig.WAITING_VERIFICATION_PERSONAL_DATA
        };
    }

    public void VerificationRejected(CompanyCreditDraftRejectedDTO dto, string userId, string role)
    {
        var companyCredit = _repository.GetById(dto.Id);

        if (companyCredit.CreditApplicationNumber == "-")
        {
            throw new Exception();
        }

        companyCredit.Notes = dto.Notes;
        companyCredit.VerifiedBy = userId;
        companyCredit.VerifiedAt = DateTime.Now;

        if (role == "Supervisor")
        {
            companyCredit.Status = ApprovalStatusConfig.REJECTED_FILES;
        }

        if (role == "Manager")
        {
            companyCredit.Status = ApprovalStatusConfig.REJECTED;
        }
        _repository.Verification(companyCredit);
    }

    public void VerificationApproved(string id, string userId, string role)
    {
        var companyCredit = _repository.GetById(id);

        if (companyCredit.CreditApplicationNumber == "-")
        {
            throw new Exception();
        }

        companyCredit.VerifiedBy = userId;
        companyCredit.VerifiedAt = DateTime.Now;

        if (role == "Supervisor")
        {
            companyCredit.Status = ApprovalStatusConfig.WAITING_VERIFICATION_MANAGER;
        }

        if (role == "Manager")
        {
            companyCredit.Status = ApprovalStatusConfig.APPROVED;
            companyCredit.CreditStartDate = DateTime.Now;
            companyCredit.CompanyOwner.CompanyCreditLimit -= companyCredit.ApplicationAmount;
        }

        _repository.Verification(companyCredit);
    }
}