using MidasDataAccess.Models;

namespace MidasBussines;

public interface ISubdistrictRepository
{
    public List<SubDistrict> Get(int page, int pageSize, string cityId, string name);

    public List<SubDistrict> Get(string cityId);

    public SubDistrict? GetById(string id);

    public void Insert(SubDistrict req);

    public void Update(SubDistrict req);

    public int Count(string name, string cityId);
}
