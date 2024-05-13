using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class CreditUpgrade
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string CreditUpgradeNumber { get; set; } = null!;

    public decimal MonthlyIncome { get; set; }

    public decimal AnnualBusinessGross { get; set; }

    public decimal ProfitBusinessGross { get; set; }

    public string Status { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string FinancialStatementFile { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ApprovedByNavigation { get; set; }

    public virtual User? DeletedByNavigation { get; set; }

    public virtual FileManagement FinancialStatementFileNavigation { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual User User { get; set; } = null!;
}
