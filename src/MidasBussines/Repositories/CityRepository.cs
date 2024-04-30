using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class CityRepository : ICityRepository
{
    private readonly MidasContext _dbContext;

    public CityRepository(MidasContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<City> Get(int pageNumber, int pageSize, string name, string provinceId)
    {
        return _dbContext.Cities
        .Where(city => city.DeletedAt == null && city.Name.ToLower().Contains(name??"".ToLower()) && city.ProvinceId == provinceId && city.Province.DeletedAt == null)
        .Skip((pageNumber - 1) * pageSize)
        .Take(pageSize)
        .ToList();
    }

    public List<City> Get(string provinceId)
    {
        return _dbContext.Cities
        .Where(city => city.DeletedAt == null && city.ProvinceId == provinceId && city.Province.DeletedAt == null)
        .ToList();
    }

    public City? GetById(string id)
    {
        return _dbContext.Cities.Find(id);
    }

    public void Insert(City city)
    {
        try
        {
            var prov = _dbContext.Provinces.Find(city.ProvinceId) ?? throw new Exception();
            if (prov.DeletedAt == null)
            {
                _dbContext.Cities.Add(city);
                _dbContext.SaveChanges();
            } else
            {
                throw new Exception();
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(City city)
    {
        try
        {
            _dbContext.Cities.Update(city);
            _dbContext.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public int Count(string name, string provinceId)
    {
        return _dbContext.Cities
        .Where(city => city.DeletedAt == null && city.Name.ToLower().Contains(name??"".ToLower()) && city.ProvinceId == provinceId && city.Province.DeletedAt == null)
        .Count();
    }
}
