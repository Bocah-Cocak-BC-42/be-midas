using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.CompanyCredit;

public class CompanyCreditInsertDTO
{
    public string Npwp { get; set; } = null!;
    public string CompanyName { get; set; } = null!;
    public string CompanyType { get; set; } = null!;
    public string PlaceOfEstasblishment { get; set; } = null!;
    public string EstablishRegistrationNumber { get; set; } = null!;
    public DateOnly EstablishRegistrationDate { get; set; }
    public string CompanyRegistrationNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string VillageId { get; set; } = null!;
    public string BranchOfficeId { get; set; } = null!;
    public decimal ApplicationAmount { get; set; }
    public int ApplicationPeriod { get; set; }
    public DateTime CreditEndDate { get; set; }
    public string Notes { get; set; } = null!;
    public string EstablishRegistrationNumberFile { get; set; } = null!;
    public string CompanyRegistrationNumberFile { get; set; } = null!;
    public string Npwpfile { get; set; } = null!;
    public string IdentityNumberFile { get; set; } = null!;
    public string BoardOfManagementFile { get; set; } = null!;
    public string FinancialStatementFile { get; set; } = null!;
}
