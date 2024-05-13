using Microsoft.EntityFrameworkCore;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class AssociateUserBranchRepository : IAssociateUserBranchRepository
{
    private readonly MidasContext _context;

    public AssociateUserBranchRepository(MidasContext context)
    {
        _context = context;
    }

    public void Delete(string id)
    {
        try
        {
            _context.AssociateUserBranches.Remove(_context.AssociateUserBranches.First(associate=>associate.Id == id));
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public List<AssociateUserBranch> Get()=>
        _context.AssociateUserBranches
        .Include(associate=>associate.User)
            .ThenInclude(user=>user.Role)
        .Include(associate=>associate.BranchOffice)
        .ToList();
    public List<AssociateUserBranch> GetEmployeeByOffice(int page, int pageSize, string branchOfficeId, string fullName, string role)
    {
        return _context.AssociateUserBranches
        .Where(
            associate=>associate.BranchOfficeId == branchOfficeId&&
            associate.User.FullName.Contains(fullName ?? "") &&
            associate.User.Role.Name.Contains(role ?? "")
        )
        .Include(associate=>associate.User)
            .ThenInclude(user=>user.Role)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();
    }
    public int CountDataEmployeeByOffice(string branchOfficeId, string fullName, string role)
    {
        return _context.AssociateUserBranches
        .Where(
            associate=>associate.BranchOfficeId == branchOfficeId&&
            associate.User.FullName.Contains(fullName ?? "") &&
            associate.User.Role.Name.Contains(role ?? "")
        )
        .Include(associate=>associate.User)
            .ThenInclude(user=>user.Role)
        .Count();
    }
    public AssociateUserBranch? Get(string id)=>
        _context.AssociateUserBranches
        .FirstOrDefault(associate=>associate.Id == id);
    public void Insert(AssociateUserBranch req)
    {
        try
        {
            _context.AssociateUserBranches.Add(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(AssociateUserBranch req)
    {
        try
        {
            _context.AssociateUserBranches.Update(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
