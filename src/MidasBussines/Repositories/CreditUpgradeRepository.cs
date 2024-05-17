using Azure;
using Microsoft.EntityFrameworkCore;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class CreditUpgradeRepository : ICreditUpgradeRepository
{
    private readonly MidasContext _context;

    public CreditUpgradeRepository(MidasContext context)
    {
        _context = context;
    }

    public CreditUpgrade? Get(string id)
    {
        return _context
            .CreditUpgrades
            .Include(c => c.User)
            .FirstOrDefault(c => c.Id == id);
    }

    public List<CreditUpgrade> GetCreditUpgradesCustomer(string userId)
    {
        return _context
            .CreditUpgrades
            .Include(c => c.User)
            .Include(c => c.VerifiedByNavigation)
            .Where(c => c.UserId == userId)
            .ToList();
    }

    public List<CreditUpgrade> GetCreditUpgradeAdmin(int page, int pageSize)
    {
        return _context.CreditUpgrades
            .Include(c => c.User)
            .Include(c => c.VerifiedByNavigation)
            .Skip((page-1)*pageSize)
            .Take(pageSize)
            .ToList();
    }
    public List<CreditUpgrade> GetCreditUpgradeSupervisor(int page, int pageSize)
    {
        return _context.CreditUpgrades
            .Where(c => c.VerifiedByNavigation.Role.Name == "Admin")
            .Include(c => c.User)
            .Include( c => c.VerifiedByNavigation)
                .ThenInclude( u => u.Role)
            .Skip((page-1)*pageSize)
            .Take(pageSize)
            .ToList() ?? throw new Exception("No data found");
    }

    public void Insert(CreditUpgrade creditUpgrade)
    {
        _context.CreditUpgrades.Add(creditUpgrade);
        _context.SaveChanges();
    }

    public void Update(CreditUpgrade creditUpgrade)
    {
        _context.CreditUpgrades.Update(creditUpgrade);
        _context.SaveChanges();
    }

    public User GetVerifiedBy(string creditUpgradeId)
    {
        var creditUpg = _context
            .CreditUpgrades
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == creditUpgradeId);

        if(creditUpg.VerifiedBy == null) return null;
        
        return _context
            .Users
            .Include(u => u.Role)
            .First(u => u.Id == creditUpg.VerifiedBy);
        
    }
}
