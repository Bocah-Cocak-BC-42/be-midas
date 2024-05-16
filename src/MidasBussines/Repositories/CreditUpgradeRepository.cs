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
            .Where(c => c.UserId == userId)
            .ToList();
    }

    public List<CreditUpgrade> GetCreditUpgradeAdmin(int page, int pageSize)
    {
        return _context.CreditUpgrades
            .Include(c => c.User)
            .Skip((page-1)*pageSize)
            .Take(pageSize)
            .ToList();
    }
    public List<CreditUpgrade> GetCreditUpgradeSupervisor(int page, int pageSize)
    {
        return _context.CreditUpgrades
            .Where(c => c.ApprovedByNavigation.Role.Name == "Admin")
            .Include(c => c.User)
            .Include( c => c.ApprovedByNavigation)
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
}
