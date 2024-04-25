using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class BusinessSector
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? DeletedByNavigation { get; set; }

    public virtual ICollection<IndividualCredit> IndividualCredits { get; set; } = new List<IndividualCredit>();

    public virtual User? UpdatedByNavigation { get; set; }
}
