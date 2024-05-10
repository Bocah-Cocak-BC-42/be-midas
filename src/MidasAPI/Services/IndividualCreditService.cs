using MidasBussines.Interfaces;
using MidasAPI.DTO.IndividualCredit;
using MidasDataAccess.Models;
using MidasAPI.DTOs;

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

    public void Insert(IndividualCreditInsertDTO request, string userId)
    {
        var individualCredit = new IndividualCredit()
        {
            Id = Guid.NewGuid().ToString(),
            CreditApplicationNumber = "-",
            UserId = userId,
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
            DomicileFile = request.DomicileFile,
            IdentityCardFile = request.IdentityCardFile,
            IdentityCardSelfieFile = request.IdentityCardSelfieFile,
            FamilyCardFile = request.FamilyCardFile,
            BusinessCertificateFile = request.BusinessCertificateFile,
            Status = ApprovalStatusConfig.DRAFT,
            CreatedBy = userId,
            CreatedAt = DateTime.Now
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
