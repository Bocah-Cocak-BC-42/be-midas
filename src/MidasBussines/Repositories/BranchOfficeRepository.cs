using Microsoft.EntityFrameworkCore;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class BranchOfficeRepository : IBranchOfficeRepository
{
    private readonly MidasContext _context;

    public BranchOfficeRepository(MidasContext context)
    {
        _context = context;
    }

    public int CountData(string officeName, string province, string city) =>
        _context.BranchOffices
        .Where(office=>
            office.DeletedAt == null &&
            office.OfficeName.ToString().ToLower().Contains(officeName??"".ToLower())&&
            office.Village.SubDistrict.City.Province.Name.ToString().ToLower().Contains(province??"".ToLower())&&
            office.Village.SubDistrict.City.Name.ToString().ToLower().Contains(city??"".ToLower())
        )
        .Include(office=>office.Village)
                .ThenInclude(village=>village.SubDistrict)
                    .ThenInclude(subDistrict=>subDistrict.City)
                        .ThenInclude(city=>city.Province)
        .Count();

    public void Delete(string id)
    {
        try
        {
            _context.BranchOffices.Remove(_context.BranchOffices.First(office=>office.Id == id));
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public List<BranchOffice> Get() =>
        _context.BranchOffices
            .Where(office=>office.DeletedAt == null)
            .Include(office=>office.Village)
                .ThenInclude(village=>village.SubDistrict)
                    .ThenInclude(subDistrict=>subDistrict.City)
                        .ThenInclude(city=>city.Province)
            .ToList();


    public List<BranchOffice> Get(int page, int pageSize, string officeName, string province, string city) =>
        _context.BranchOffices
        .Where(office=>
            office.DeletedAt == null &&
            office.OfficeName.ToString().ToLower().Contains(officeName??"".ToLower())&&
            office.Village.SubDistrict.City.Province.Name.ToString().ToLower().Contains(province??"".ToLower())&&
            office.Village.SubDistrict.City.Name.ToString().ToLower().Contains(city??"".ToLower())
        )
        .Include(office=>office.Village)
                .ThenInclude(village=>village.SubDistrict)
                    .ThenInclude(subDistrict=>subDistrict.City)
                        .ThenInclude(city=>city.Province)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();

    public BranchOffice? Get(string id) =>
        _context.BranchOffices
        .Where(office=>office.DeletedAt == null)
        .Include(office=>office.Village)
                .ThenInclude(village=>village.SubDistrict)
                    .ThenInclude(subDistrict=>subDistrict.City)
                        .ThenInclude(city=>city.Province)
        .FirstOrDefault(office => office.Id == id);

    public void Insert(BranchOffice req)
    {
        try
        {
            _context.BranchOffices.Add(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(BranchOffice req)
    {
        try
        {
            _context.BranchOffices.Update(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
