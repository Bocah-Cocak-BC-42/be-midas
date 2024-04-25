using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class EmergencyContact
{
    public string Id { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string IndividualCreditId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Relative { get; set; } = null!;

    public virtual IndividualCredit IndividualCredit { get; set; } = null!;
}
