﻿using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class Withdrawal
{
    public string Id { get; set; } = null!;

    public string BankId { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string? IndividualCreditId { get; set; }

    public string? CompanyCreditId { get; set; }

    public string ReceiptFile { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedAt { get; set; }

    public virtual Bank Bank { get; set; } = null!;

    public virtual CompanyCredit? CompanyCredit { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? DeletedByNavigation { get; set; }

    public virtual IndividualCredit? IndividualCredit { get; set; }

    public virtual FileManagement ReceiptFileNavigation { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual User? VerifiedByNavigation { get; set; }
}
