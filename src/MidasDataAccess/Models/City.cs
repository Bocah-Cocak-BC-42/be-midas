using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class City
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ProvinceId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? DeletedByNavigation { get; set; }

    public virtual Province Province { get; set; } = null!;

    public virtual ICollection<SubDistrict> SubDistricts { get; set; } = new List<SubDistrict>();

    public virtual User? UpdatedByNavigation { get; set; }
}
