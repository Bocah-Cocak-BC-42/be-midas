using MidasAPI.DTO.IndividualCredit;

namespace MidasAPI.DTOs.IndividualCredit
{
    public class IndividualCreditResponseDTO
    {
        public string Id { get; set; } = null!;
        public string CreditApplicationNumber { get; set; } = null!;
        public string UserId { get; set; } = null!;

        public string FamilyCardNumber { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string VillageId { get; set; } = null!;

        public string BusinessSectorId { get; set; } = null!;

        public string BusinessAddress { get; set; } = null!;

        public string BusinessPhoneNumber { get; set; } = null!;

        public int BusinessPeriod { get; set; }

        public string BusinessPlaceStatus { get; set; } = null!;

        public int TotalEmployee { get; set; }

        public string BusinessVillage { get; set; } = null!;

        public string BranchOfficeId { get; set; } = null!;

        public decimal ApplicationAmount { get; set; }

        public int ApplicationPeriod { get; set; }

        public DateTime? ApplicationDate { get; set; }

        public string DomicileFile { get; set; } = null!;

        public string IdentityCardFile { get; set; } = null!;

        public string IdentityCardSelfieFile { get; set; } = null!;

        public string FamilyCardFile { get; set; } = null!;

        public string BusinessCertificateFile { get; set; } = null!;

        public List<EmergencyContactDTO> EmergencyContacts { get; set; } = new List<EmergencyContactDTO>();
    }
}
