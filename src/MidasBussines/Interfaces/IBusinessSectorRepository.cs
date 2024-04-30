using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IBusinessSectorRepository
{
    List<BusinessSector> Get();
    List<BusinessSector> Get(int page, int pageSize, string name);
    BusinessSector? Get(string id);
    void Insert(BusinessSector req);
    void Update(BusinessSector req);
    void Delete(string id);
    int CountData(string name);
}
