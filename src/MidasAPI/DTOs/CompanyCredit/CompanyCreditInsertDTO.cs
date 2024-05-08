using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.CompanyCredit;

public class CompanyCreditInsertDTO
{   

    //Valdasi unique
    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage ="{0} harus berupa angka")]
    [Length(16, 16, ErrorMessage = "{0} harus 16 karakter")]
    [Display(Name = "NPWP Badan Usaha")]
    public string Npwp { get; set; } = null!;



    [Required(ErrorMessage = "")]
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
    public string CompanyOwnerId { get; set; } = null!;
    public string BranchOfficeId { get; set; } = null!;
    public decimal ApplicationAmount { get; set; }
    public int ApplicationPeriod { get; set; }
    public DateTime? ApplicationDate { get; set; }
    public DateTime CreditEndDate { get; set; }
    public string Status { get; set; } = null!;
    public string Notes { get; set; } = null!;
    public string EstablishRegistrationNumberFile { get; set; } = null!;
    public string CompanyRegistrationNumberFile { get; set; } = null!;
    public string Npwpfile { get; set; } = null!;
    public string IdentityNumberFile { get; set; } = null!;
    public string BoardOfManagementFile { get; set; } = null!;
    public string FinancialStatementFile { get; set; } = null!;

    public BranchOfficeResponseDTO BranchOffice { get; set; }
}
