using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IProvinceRepository
{
    List<Province> Get(int pageNumber, int pageSize, string name);
    List<Province> Get();
    Province? GetById(string id);
    void Insert(Province province);
    void Update(Province province);
    int Count(string name);
}
