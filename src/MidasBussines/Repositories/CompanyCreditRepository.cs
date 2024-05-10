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


    public List<CompanyCredit> GetDraft(int page, int pageSize)
    {
        var companyCredit = _context.CompanyCredits;
        return companyCredit
            .Include("BranchOffice")
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();     
    }


    public int CountData(){
        var companyCredit = _context.CompanyCredits;
        return companyCredit.Count();
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
