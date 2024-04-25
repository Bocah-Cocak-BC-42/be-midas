﻿using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class AssociateUserBranch
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string BranchOfficeId { get; set; } = null!;

    public virtual BranchOffice BranchOffice { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
