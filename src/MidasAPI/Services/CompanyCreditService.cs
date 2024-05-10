using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration.UserSecrets;
using MidasAPI.DTOs;
using MidasAPI.DTOs.CompanyCredit;
using MidasAPI.DTOs.User;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class CompanyCreditService
{
    private readonly ICompanyCreditRepository _repository;
    private readonly IUserRepository _userRepository;

    public CompanyCreditService(ICompanyCreditRepository repository, IUserRepository userRepository)
    {
        _repository = repository;
        _userRepository = userRepository;
    }

    private string CreateCreditApplicationNumber(string branchOfficeCode, string nik)
    {
        return $"KBU-{branchOfficeCode}-{nik}-{DateTime.Now.ToString("ddMMyyyy")}";
    }

    private string GetUserNIK(string userId)
    {
        var nik = _userRepository.GetById(userId).IdentityNumber;
        return nik;
    }

    public List<SelectListItem> GetCompanyTypes()
    {
        return new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Perseroan Terbatas (PT)", Value = "PT" },
            new SelectListItem() { Text = "Commanditaire Vennootschap", Value = "CV" },
            new SelectListItem() { Text = "Koperasi", Value = "Koperasi" },
            new SelectListItem() { Text = "Koperasi Unit Desa (KUD)", Value = "KUD" },
            new SelectListItem() { Text = "Perusahaan Dagang", Value = "PD" }
        };
    }

    public void Insert(CompanyCreditInsertDraftDTO dto, string userId)
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
            VillageId = dto.VillageId,
            BranchOfficeId = dto.BranchOfficeId,
            ApplicationAmount = dto.ApplicationAmount,
            ApplicationPeriod = dto.ApplicationPeriod,
            CreditEndDate = dto.CreditEndDate,
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

        _repository.Insert(companyCredit);
    }

    public void UpdateDraft(CompanyCreditUpdateDraftDTO dto, string userId)
    {
        var companyCredit = _repository.GetById(dto.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("company credit"));

        companyCredit.CreditApplicationNumber = "-";
        companyCredit.Npwp = dto.Npwp;
        companyCredit.CompanyName = dto.CompanyName;
        companyCredit.CompanyType = dto.CompanyType;
        companyCredit.PlaceOfEstasblishment = dto.PlaceOfEstasblishment;
        companyCredit.EstablishRegistrationNumber = dto.EstablishRegistrationNumber;
        companyCredit.CompanyRegistrationNumber = dto.CompanyRegistrationNumber;
        companyCredit.Email = dto.Email;
        companyCredit.PhoneNumber = dto.PhoneNumber;
        companyCredit.Address = dto.Address;
        companyCredit.VillageId = dto.VillageId;
        companyCredit.BranchOfficeId = dto.BranchOfficeId;
        companyCredit.ApplicationAmount = dto.ApplicationAmount;
        companyCredit.ApplicationPeriod = dto.ApplicationPeriod;
        companyCredit.CreditEndDate = dto.CreditEndDate;
        companyCredit.Status = ApprovalStatusConfig.DRAFT;
        companyCredit.EstablishRegistrationNumberFile = dto.EstablishRegistrationNumberFile;
        companyCredit.Npwpfile = dto.Npwpfile;
        companyCredit.IdentityNumberFile = dto.IdentityNumberFile;
        companyCredit.BoardOfManagementFile = dto.BoardOfManagementFile;
        companyCredit.FinancialStatementFile = dto.FinancialStatementFile;
        companyCredit.UpdatedBy = userId;
        companyCredit.UpdatedAt = DateTime.Now;

        _repository.UpdateDraft(companyCredit);
    }

    public void DeleteDraft(string id, string userId)
    {
        var companyCredit = _repository.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("company credit"));
        companyCredit.DeletedBy = userId;
        companyCredit.DeletedAt = DateTime.Now;

        _repository.UpdateDraft(companyCredit);
    }

    public void ApplyCredit(string id, string userId)
    {
        var companyCredit = _repository.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("company credit"));
        companyCredit.CreditApplicationNumber = CreateCreditApplicationNumber(companyCredit.BranchOffice.OfficeCode, GetUserNIK(userId));
        companyCredit.ApplicationDate = DateTime.Today;
        companyCredit.Status = "Verif";

        _repository.ApplyCredit(companyCredit);
    }

    public void CreditRejected(CompanyCreditDraftRevisionDTO dto, string userId)
    {
        var companyCredit = _repository.GetById(dto.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("company credit"));
        companyCredit.Notes = dto.Notes;
        companyCredit.Status = ApprovalStatusConfig.REJECTED_FILES;
        companyCredit.UpdatedBy = userId;
        companyCredit.UpdatedAt = DateTime.Now;

        _repository.CreditRejected(companyCredit);
    }
}
