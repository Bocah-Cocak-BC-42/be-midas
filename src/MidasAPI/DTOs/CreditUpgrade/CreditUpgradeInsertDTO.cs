namespace MidasAPI.DTOs;

public class CreditUpgradeInsertDTO
{
    public decimal MonthlyIncome { get; set; }
    public decimal AnnualBusinessGross { get; set; }
    public decimal ProfitBusinessGross { get; set; }
    public string FinancialStatementFileId { get; set; } = null!;
    public string Notes { get; set; } = null!;
}
