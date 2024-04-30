using MidasDataAccess.Models;

namespace MidasBussines;

public class SubdistrictRepository : ISubdistrictRepository
{
    private readonly MidasContext _context;

    public SubdistrictRepository(MidasContext context)
    {
        _context = context;
    }

    public List<SubDistrict> Get(int page, int pageSize, string cityId, string name)
    {
        return _context.SubDistricts
        .Where(x => x.CityId == cityId && x.Name.ToLower().Contains(name ?? "".ToLower()) && x.DeletedAt == null)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();
    }

    public List<SubDistrict> Get(string cityId)
    {
        return _context.SubDistricts
        .Where(x => x.CityId == cityId && x.DeletedAt == null)
        .ToList();
    }

    public SubDistrict? GetById(string cityId)
    {
        return _context.SubDistricts.Find(cityId);
    }

    public void Insert(SubDistrict req)
    {
        try
        {
            var city = _context.Cities.Find(req.CityId);
            if (city.DeletedAt == null)
            {
                _context.SubDistricts.Add(req);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception();
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(SubDistrict req)
    {
        try
        {
            _context.SubDistricts.Update(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public int Count(string name, string cityId)
    {
        return _context.SubDistricts
        .Where(x => x.CityId == cityId && x.Name.ToLower().Contains(name ?? "".ToLower()) && x.DeletedAt == null)
        .Count();
    }
}
