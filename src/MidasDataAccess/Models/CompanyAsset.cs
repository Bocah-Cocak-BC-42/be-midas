using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class CompanyAsset
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Value { get; set; }

    public string CompanyId { get; set; } = null!;

    public virtual CompanyCredit Company { get; set; } = null!;
}
