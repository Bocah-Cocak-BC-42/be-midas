using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class ProvinceRepository : IProvinceRepository
{
    private readonly MidasContext _context;

    public ProvinceRepository(MidasContext context)
    {
        _context = context;
    }

    public List<Province> Get(int page, int pageSize, string name)
    {
        return _context.Provinces
        .Where(prov => prov.DeletedAt == null && prov.Name.ToLower().Contains(name??"".ToLower()))
        .OrderBy(prov => prov.Name)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();
    }

    public List<Province> Get()
    {
        return _context.Provinces
        .Where(prov => prov.DeletedAt == null)
        .OrderBy(prov => prov.Name)
        .ToList();
    }

    public Province? GetById(string id)
    {
        return _context.Provinces.Find(id);
    }

    public void Insert(Province province)
    {
        try
        {
            var isExist = _context.Provinces.Any(
                prov => prov.Name == province.Name
            );

            if (!isExist)
            {
                _context.Provinces.Add(province);
                _context.SaveChanges();
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

    public void Update(Province province)
    {
        try
        {
            _context.Provinces.Update(province);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public int Count(string name)
    {
        return _context.Provinces
        .Where(prov => prov.DeletedAt == null && prov.Name.ToLower().Contains(name??"".ToLower()))
        .Count();
    }
}
