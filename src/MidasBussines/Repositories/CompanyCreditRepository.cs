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

    public List<CompanyCredit> GetDraft(int page, int pageSize, string status)
    {
        var companyCredit = _context.CompanyCredits;
        return companyCredit
            .Include("BranchOffice")
            .Where(c => c.Status == status)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();     
    }

    public List<CompanyCredit> GetCreditPerCustomer(int page, int pageSize, string customerId){
        var companyCredit = _context.CompanyCredits;
        return companyCredit
            .Include("CreatedByNavigation")
            .Include("BranchOffice")
            .Where(c => c.CreatedBy == customerId)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int CountData(){
        var companyCredit = _context.CompanyCredits;
        return companyCredit.Count();
    }

    public int CountData(string customerId){
        var companyCredit = _context.CompanyCredits;
        return companyCredit
            .Include("CreatedByNavigation")
            .Where(c => c.CreatedBy == customerId)
            .Count();
    }

    public CompanyCredit GetById(string id)
    {
        return _context.CompanyCredits
        .Include(companyCredit => companyCredit.CompanyOwner)
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

    public void Verification(CompanyCredit companyCredit)
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
