using MidasBussines.Interfaces;
using MidasAPI.DTO.IndividualCredit;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class IndividualCreditService
{
    private readonly IIndividualCreditRepository _individualCreditRepository;
    private readonly IEmergencyContactRepository _emergencyContactRepository;

    public IndividualCreditService(IIndividualCreditRepository individualCreditRepository, IEmergencyContactRepository emergencyContactRepository)
    {
        _individualCreditRepository = individualCreditRepository;
        _emergencyContactRepository = emergencyContactRepository;
    }

    public void Insert(IndividualCreditInsertDTO request)
    {
        var individualCredit = new IndividualCredit()
        {
            Id = Guid.NewGuid().ToString(),
            CreditApplicationNumber = "-",
            UserId = request.UserId,
            FamilyCardNumber = request.FamilyCardNumber,
            Address = request.Address,
            VillageId = request.VillageId,
            BusinessSectorId = request.BusinessSectorId,
            BusinessAddress = request.BusinessAddress,
            BusinessPhoneNumber = request.BusinessPhoneNumber,
            BusinessPeriod = request.BusinessPeriod,
            BusinessPlaceStatus = request.BusinessPlaceStatus,
            TotalEmployee = request.TotalEmployee,
            BusinessVillage = request.BusinessVillage,
            BranchOfficeId = request.BranchOfficeId,
            ApplicationAmount = request.ApplicationAmount,
            ApplicationPeriod = request.ApplicationPeriod,
            ApplicationDate = request.ApplicationDate,
            DomicileFile = request.DomicileFile,
            IdentityCardFile = request.IdentityCardFile,
            IdentityCardSelfieFile = request.IdentityCardSelfieFile,
            FamilyCardFile = request.FamilyCardFile,
            BusinessCertificateFile = request.BusinessCertificateFile,
            CreatedBy = request.CreatedBy,
            CreatedAt = request.CreatedAt
        };

        _individualCreditRepository.Insert(individualCredit);

        foreach (var contact in request.EmergencyContacts)
        {
            var emergencyContact = new EmergencyContact
            {
                Id = Guid.NewGuid().ToString(),
                PhoneNumber = contact.PhoneNumber,
                Name = contact.Name,
                Relative = contact.Relative,
                IndividualCreditId = individualCredit.Id
            };
            _emergencyContactRepository.Insert(emergencyContact);
        }

    }
}
