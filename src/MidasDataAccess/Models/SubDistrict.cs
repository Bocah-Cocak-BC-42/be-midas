using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class SubDistrict
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CityId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? DeletedByNavigation { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual ICollection<Village> Villages { get; set; } = new List<Village>();
}
