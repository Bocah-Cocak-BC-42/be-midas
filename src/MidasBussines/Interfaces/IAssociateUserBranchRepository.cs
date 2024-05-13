using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IAssociateUserBranchRepository
{
    List<AssociateUserBranch> Get();
    List<AssociateUserBranch> GetEmployeeByOffice(int page, int pageSize, string branchOfficeId, string fullName, string role);
    int CountDataEmployeeByOffice(string branchOfficeId, string fullName, string role);
    AssociateUserBranch? Get(string id);
    void Insert(AssociateUserBranch req);
    void Update(AssociateUserBranch req);
    void Delete(string id);
}
