using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IAssociateUserBranchRepository
{
    List<AssociateUserBranch> Get();
    AssociateUserBranch? Get(string id);
    void Insert(AssociateUserBranch req);
    void Update(AssociateUserBranch req);
    void Delete(string id);
}
