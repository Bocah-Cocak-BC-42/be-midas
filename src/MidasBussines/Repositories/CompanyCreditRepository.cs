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

    public List<CompanyCredit> GetByStatus(int page, int pageSize, string status, string userId)
    {   
        var companyCredit = _context.CompanyCredits;
        return companyCredit
            .Include("BranchOffice")
            .Include("CreatedByNavigation")
            .Where(c => (status == "" ? true : c.Status == status) && (userId == "" ? true : c.CreatedBy == userId) 
                && c.DeletedAt == null)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();     
    }

    public int CountData(){
        var companyCredit = _context.CompanyCredits;
        return companyCredit.Count();
    }

    public int CountData(string userId){
        var companyCredit = _context.CompanyCredits;
        return companyCredit
            .Include("CreatedByNavigation")
            .Where(c => c.CreatedBy == userId)
            .Count();
    }

    public CompanyCredit GetById(string id)
    {
        return _context.CompanyCredits
        .Include(companyCredit => companyCredit.BranchOffice)
        .Where(companyCredit => companyCredit.Id == id)
        .FirstOrDefault();
    }

    public void InsertDraft(CompanyCredit companyCredit)
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

    public void CreditVerification(CompanyCredit companyCredit)
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

    public void CreditRevision(CompanyCredit companyCredit)
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

    public void FinalVerification(CompanyCredit companyCredit)
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
