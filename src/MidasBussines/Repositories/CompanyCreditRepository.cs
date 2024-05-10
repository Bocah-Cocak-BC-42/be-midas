using Microsoft.EntityFrameworkCore;
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

    public CompanyCredit GetById(string id)
    {
        return _context.CompanyCredits
        .Include(companyCredit => companyCredit.BranchOffice)
        .Where(companyCredit => companyCredit.Id == id)
        .FirstOrDefault();
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

    public void UpdateDraft(CompanyCredit companyCredit)
    {
        try
        {
            _context.CompanyCredits.Update(companyCredit);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void ApplyCredit(CompanyCredit companyCredit)
    {
        try
        {
            _context.CompanyCredits.Update(companyCredit);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void CreditRejected(CompanyCredit companyCredit)
    {
        try
        {
            _context.CompanyCredits.Update(companyCredit);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
