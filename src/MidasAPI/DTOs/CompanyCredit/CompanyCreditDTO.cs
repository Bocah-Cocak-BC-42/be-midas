namespace MidasAPI.DTOs.CompanyCredit;

public class CompanyCreditDTO
{
    public string CreditApplicationNumber { get; set; } = null!;
    public string BranchOffice { get; set; } = null!;
    public decimal ApplicationAmount { get; set; }
    public int ApplicationPeriod { get; set; }
    public string Status { get; set; } = null!;
}
