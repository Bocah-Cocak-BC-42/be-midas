using MidasAPI.Validations.AssociateUserBranch;
namespace MidasAPI.DTOs.AssociateUserBranch;

public class AssociateUserBranchUpdateDTO
{
    
    public string Id { get; set; } = null!;
    [StaffAndSupervisorUpdateValidation]
    public string UserId { get; set; } = null!;
    public string BranchOfficeId { get; set; } = null!;
}
