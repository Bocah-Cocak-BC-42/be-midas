namespace MidasAPI.DTOs;

public class CreditUpgradeResponseDTO
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public string FullName { get; set; } = null!;

    public string CreditUpgradeNumber { get; set; } = null!;

    public decimal MonthlyIncome { get; set; }

    public decimal AnnualBusinessGross { get; set; }

    public decimal ProfitBusinessGross { get; set; }

    public string Status { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string FinancialStatementFile { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedAt { get; set; }
}
