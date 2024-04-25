using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class PostalCode
{
    public string Id { get; set; } = null!;

    public string PostalCode1 { get; set; } = null!;

    public string VillageId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<BranchOffice> BranchOffices { get; set; } = new List<BranchOffice>();

    public virtual ICollection<CompanyCredit> CompanyCredits { get; set; } = new List<CompanyCredit>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? DeletedByNavigation { get; set; }

    public virtual ICollection<IndividualCredit> IndividualCreditBusinessPostalCodeNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditPostalCodes { get; set; } = new List<IndividualCredit>();

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual Village Village { get; set; } = null!;
}
