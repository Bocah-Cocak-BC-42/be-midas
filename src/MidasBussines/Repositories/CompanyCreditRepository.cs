using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class CompanyCreditRepository : ICompanyCreditRepository
{
    private readonly MidasContext _context;

    public CompanyCreditRepository(MidasContext context)
    {
        _context = context;
    }

    public void Insert(CompanyCredit companyCredit)
    {
        try
        {
            _context.CompanyCredits.Add(companyCredit);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
