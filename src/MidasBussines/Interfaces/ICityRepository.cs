using System.Xml.Serialization;
using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICityRepository
{
    List<City> Get(int pageNumber, int pageSize, string name, string provinceId);
    List<City> Get(string provinceId);
    City? GetById(string id);
    void Insert(City city);
    void Update(City city);
    int Count(string name, string provinceId);
}
