using MidasAPI.Validations.AssociateUserBranch;
namespace MidasAPI.DTOs.AssociateUserBranch;

public class AssociateUserBranchInsertDTO
{
    [StaffAndSupervisorValidation]
    public string UserId { get; set; } = null!;
    public string BranchOfficeId { get; set; } = null!;
}
