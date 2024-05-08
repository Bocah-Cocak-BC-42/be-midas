using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class CompanyCredit
{
    public string Id { get; set; } = null!;

    public string CreditApplicationNumber { get; set; } = null!;

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

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedAt { get; set; }

    public virtual FileManagement BoardOfManagementFileNavigation { get; set; } = null!;

    public virtual BranchOffice BranchOffice { get; set; } = null!;

    public virtual ICollection<BusinessOwnerDetail> BusinessOwnerDetails { get; set; } = new List<BusinessOwnerDetail>();

    public virtual ICollection<CompanyAsset> CompanyAssets { get; set; } = new List<CompanyAsset>();


    public virtual FileManagement CompanyRegistrationNumberFileNavigation { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<CreditPayment> CreditPayments { get; set; } = new List<CreditPayment>();

    public virtual User? DeletedByNavigation { get; set; }

    public virtual FileManagement EstablishRegistrationNumberFileNavigation { get; set; } = null!;

    public virtual FileManagement FinancialStatementFileNavigation { get; set; } = null!;

    public virtual FileManagement IdentityNumberFileNavigation { get; set; } = null!;

    public virtual FileManagement NpwpfileNavigation { get; set; } = null!;

    public virtual Village Village { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual User? VerifiedByNavigation { get; set; }

    public virtual ICollection<Withdrawal> Withdrawals { get; set; } = new List<Withdrawal>();
}
