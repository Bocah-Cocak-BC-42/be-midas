using MidasAPI.Validations.AssociateUserBranch;
namespace MidasAPI;

public class AssociateUserBranchUpdateDTO
{
    
    public string Id { get; set; } = null!;
    [StaffAndSupervisorValidation]
    public string UserId { get; set; } = null!;
    public string BranchOfficeId { get; set; } = null!;
}
