using Microsoft.AspNetCore.Mvc.Rendering;
using MidasAPI.DTOs;
using MidasAPI.DTOs.CompanyCredit;
using MidasAPI.DTOs.User;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class CompanyCreditService
{
    private readonly ICompanyCreditRepository _repository;
    private readonly IBranchOfficeRepository _branchOfficeRepository;

    public CompanyCreditService(ICompanyCreditRepository repository, IBranchOfficeRepository branchOfficeRepository)
    {
        _repository = repository;
        _branchOfficeRepository = branchOfficeRepository;
    }


    public List<CompanyCreditDTO> GetDraft(int page, int pageSize){
        var model = _repository
            .GetDraft(page, pageSize)
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


    private string CreateCreditApplicationNumber(string branchOfficeCode, string nik)
    {
        return $"KBU-{branchOfficeCode}-{nik}-{DateTime.Now.ToString("ddMMyyyy")}";
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

    public void Insert(CompanyCreditInsertDTO dto, string userId)
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
            Notes = dto.Notes,
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
}
