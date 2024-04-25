using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class BranchOffice
{
    public string Id { get; set; } = null!;

    public string OfficeName { get; set; } = null!;

    public string OfficeCode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PostalCodeId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<AssociateUserBranch> AssociateUserBranches { get; set; } = new List<AssociateUserBranch>();

    public virtual ICollection<CompanyCredit> CompanyCredits { get; set; } = new List<CompanyCredit>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? DeletedByNavigation { get; set; }

    public virtual ICollection<IndividualCredit> IndividualCredits { get; set; } = new List<IndividualCredit>();

    public virtual PostalCode PostalCode { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
