using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IBranchOfficeRepository
{
    List<BranchOffice> Get();
    List<BranchOffice> Get(int page, int pageSize, string officeName, string province, string city);
    BranchOffice? Get(string id);
    void Insert(BranchOffice req);
    void Update(BranchOffice req);
    void Delete(string id);
    int CountData(string officeName, string province, string city);
}
