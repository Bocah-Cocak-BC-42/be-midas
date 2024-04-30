using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class BusinessSectorRepository : IBusinessSectorRepository
{
    private readonly MidasContext _context;

    public BusinessSectorRepository(MidasContext context)
    {
        _context = context;
    }
    public int CountData(string name) =>
         _context.BusinessSectors
        .Where(sector=>
            sector.DeletedAt == null&&
            sector.Name.ToString().ToLower().Contains(name??"".ToLower())
        )
        .Count();
    
    public void Delete(string id)
    {
        try
        {
            _context.BusinessSectors.Remove(_context.BusinessSectors.First(sector=>sector.Id == id));
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public List<BusinessSector> Get() =>
        _context.BusinessSectors
            .Where(sector=>sector.DeletedAt == null)
            .ToList();


    public List<BusinessSector> Get(int page, int pageSize, string name) =>
        _context.BusinessSectors
            .Where(sector => 
                sector.Name.ToString().ToLower().Contains(name??"".ToLower())&&
                sector.DeletedAt == null
            )
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();


    public BusinessSector? Get(string id) =>
        _context.BusinessSectors
        .Where(sector=>sector.DeletedAt == null)
        .FirstOrDefault(sector => sector.Id == id);

    public void Insert(BusinessSector req)
    {
        try
        {
            _context.BusinessSectors.Add(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(BusinessSector req)
    {
        try
        {
            _context.BusinessSectors.Update(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
