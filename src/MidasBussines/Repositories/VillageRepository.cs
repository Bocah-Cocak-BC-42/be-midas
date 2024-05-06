using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class VillageRepository : IVillageRepository
{
    private readonly MidasContext _context;

    public VillageRepository(MidasContext context)
    {
        _context = context;
    }

    public List<Village> Get(int page, int pageSize, string subDistrictId, string name)
    {
        return _context.Villages
        .Where(x => x.SubDistrictId == subDistrictId && x.Name.ToLower().Contains(name ?? "".ToLower()) && x.DeletedAt == null)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .OrderBy(x => x.Name)
        .ToList();
    }

    public List<Village> Get(string subDistrictId)
    {
        return _context.Villages
        .Where(x => x.SubDistrictId == subDistrictId && x.DeletedAt == null)
        .OrderBy(x => x.Name)
        .ToList();
    }

    public Village? GetById(string id)
    {
        return _context.Villages.Find(id);
    }

    public void Insert(Village req)
    {
        try
        {
            var subDistrict = _context.SubDistricts.Find(req.SubDistrictId) ?? throw new Exception();
            if (subDistrict.DeletedAt == null)
            {
                _context.Villages.Add(req);
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

    public void Update(Village req)
    {
        try
        {
            _context.Villages.Update(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
    public int Count(string name, string subDistrictId)
    {
        return _context.Villages
        .Where(x => x.SubDistrictId == subDistrictId && x.Name.ToLower().Contains(name ?? "".ToLower()) && x.DeletedAt == null)
        .Count();
    }
}
