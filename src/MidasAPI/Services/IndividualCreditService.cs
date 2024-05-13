using MidasBussines.Interfaces;
using MidasAPI.DTOs.IndividualCredit;
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
            UserId = userId,
            FamilyCardNumber = request.FamilyCardNumber,
            Address = request.Address,
            VillageId = request.VillageId,
            BusinessSectorId = request.BusinessSectorId,
            BusinessAddress = request.BusinessAddress,
            BusinessPhoneNumber = request.BusinessPhoneNumber,
            BusinessPeriod = Convert.ToInt32(request.BusinessPeriod),
            BusinessPlaceStatus = request.BusinessPlaceStatus,
            TotalEmployee = Convert.ToInt32(request.TotalEmployee),
            BusinessVillage = request.BusinessVillage,
            BranchOfficeId = request.BranchOfficeId,
            ApplicationAmount = request.ApplicationAmount,
            ApplicationPeriod = Convert.ToInt32(request.ApplicationPeriod),
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

    public void Update(IndividualCreditUpdateDTO request)
    {
        var individualCredit = _individualCreditRepository.GetById(request.Id);
        if (individualCredit != null)
        {
            individualCredit.FamilyCardNumber = request.FamilyCardNumber;
            individualCredit.Address = request.Address;
            individualCredit.VillageId = request.VillageId;
            individualCredit.BusinessSectorId = request.BusinessSectorId;
            individualCredit.BusinessAddress = request.BusinessAddress;
            individualCredit.BusinessPhoneNumber = request.BusinessPhoneNumber;
            individualCredit.BusinessPeriod = Convert.ToInt32(request.BusinessPeriod);
            individualCredit.BusinessPlaceStatus = request.BusinessPlaceStatus;
            individualCredit.TotalEmployee = Convert.ToInt32(request.TotalEmployee);
            individualCredit.BusinessVillage = request.BusinessVillage;
            individualCredit.BranchOfficeId = request.BranchOfficeId;
            individualCredit.ApplicationAmount = request.ApplicationAmount;
            individualCredit.ApplicationPeriod = Convert.ToInt32(request.ApplicationPeriod);
            individualCredit.DomicileFile = request.DomicileFile;
            individualCredit.IdentityCardFile = request.IdentityCardFile;
            individualCredit.IdentityCardSelfieFile = request.IdentityCardSelfieFile;
            individualCredit.FamilyCardFile = request.FamilyCardFile;
            individualCredit.BusinessCertificateFile = request.BusinessCertificateFile;
            individualCredit.UpdatedBy = individualCredit.UserId;
            individualCredit.UpdatedAt = DateTime.Now;

            _emergencyContactRepository.DeleteByCredit(individualCredit.Id);

            foreach (var contact in request.EmergencyContacts)
            {
                var emergencyContact = new EmergencyContact()
                {
                    Id = Guid.NewGuid().ToString(),
                    PhoneNumber = contact.PhoneNumber,
                    Name = contact.Name,
                    Relative = contact.Relative,
                    IndividualCreditId = individualCredit.Id
                };
                _emergencyContactRepository.Insert(emergencyContact);
            }

            _individualCreditRepository.Update(individualCredit);

        }
    }

    public List<IndividualCreditResponseDTO> GetByStatus(int page, int pageSize, string status)
    {
        return _individualCreditRepository.GetByStatus(page, pageSize, status)
            .Select(indiv => new IndividualCreditResponseDTO()
            {
                Id = indiv.Id,
                CreditApplicationNumber = indiv.CreditApplicationNumber,
                UserId = indiv.UserId,
                FamilyCardNumber = indiv.FamilyCardNumber,
                Address = indiv.Address,
                VillageId = indiv.VillageId,
                BusinessSectorId = indiv.BusinessSectorId,
                BusinessAddress = indiv.BusinessAddress,
                BusinessPhoneNumber = indiv.BusinessPhoneNumber,
                BusinessPeriod = indiv.BusinessPeriod,
                BusinessPlaceStatus = indiv.BusinessPlaceStatus,
                TotalEmployee = indiv.TotalEmployee,
                BusinessVillage = indiv.BusinessVillage,
                BranchOfficeId = indiv.BranchOfficeId,
                ApplicationAmount = indiv.ApplicationAmount,
                ApplicationPeriod = indiv.ApplicationPeriod,
                ApplicationDate = indiv.ApplicationDate,
                DomicileFile = indiv.DomicileFile,
                IdentityCardFile = indiv.IdentityCardFile,
                IdentityCardSelfieFile = indiv.IdentityCardSelfieFile,
                FamilyCardFile = indiv.FamilyCardFile,
                BusinessCertificateFile = indiv.BusinessCertificateFile,
            }).ToList();
    }

    public void RejectCredit(string individualCreditId, string notes, string updatedById, string role)
    {
        var model = _individualCreditRepository.GetById(individualCreditId);
        model.Note = notes;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = updatedById;

        model.Status = GetRejectStatus(role);

        _individualCreditRepository.Update(model);
    }

    public void ApproveCredit(string individualCreditId, string updatedById, string role)
    {
        var model = _individualCreditRepository.GetById(individualCreditId);
        model.Note = null;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = updatedById;

        model.Status = GetApprovalStatus(role);

        _individualCreditRepository.Update(model);
    }

    private string GetRejectStatus(string role)
    {
        return
            role == "Mantri" ? ApprovalStatusConfig.REJECTED_PERSONAL_DATA :
            role == "Admin" ? ApprovalStatusConfig.REJECTED_FILES :
            role == "Supervisor" ? ApprovalStatusConfig.REJECTED_CREDIT_SCORE :
            ApprovalStatusConfig.REJECTED;
    }

    private string GetApprovalStatus(string role)
    {
        return
            role == "Mantri" ? ApprovalStatusConfig.WAITING_VERIFICATION_FILES :
            role == "Admin" ? ApprovalStatusConfig.WAITING_VERIFICATION_CREDIT_SCORE :
            role == "Supervisor" ? ApprovalStatusConfig.WAITING_VERIFICATION_MANAGER :
            ApprovalStatusConfig.APPROVED;
    }

    // public void
}
