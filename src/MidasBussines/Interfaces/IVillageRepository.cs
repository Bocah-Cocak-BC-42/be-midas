using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IVillageRepository
{
    public List<Village> Get(int page, int pageSize, string subDistrictId, string name);
    public List<Village> Get(string subDistrictId);
    public Village? GetById(string id);
    public Village? GetFullAddress(string villageId);
    public void Insert(Village req);
    public void Update(Village req);
    public int Count(string name, string subDistrictId);
}
