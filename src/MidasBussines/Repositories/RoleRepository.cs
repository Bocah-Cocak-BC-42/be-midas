using MidasDataAccess.Models;

namespace MidasBussines;

public class RoleRepository : IRoleRepository
{
    private readonly MidasContext _dbContext;

    public RoleRepository(MidasContext _dbContext)
    {
        this._dbContext = _dbContext;
    }


    public List<Role> GetRoles()
    {
        var roles = _dbContext.Roles;
        return roles
            .Where(role => role.DeletedAt == null)
            .ToList();
    }

    public List<Role> GetRoles(int page, int pageSize, string roleName){
        var roles = _dbContext.Roles;
        return roles
            .Where(role => role.DeletedAt == null && role.Name.Contains(roleName??"".ToLower()))
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }


    public int CountData(string roleName){
        var roles = _dbContext.Roles;
        return roles
            .Where(role => role.DeletedAt == null && role.Name.Contains(roleName??"".ToLower()))
            .Count();
    }

    public Role GetRoleById(string roleId){
        return _dbContext.Roles.Find(roleId);
    }

    public void Insert(Role model)
    {
        try{
            _dbContext.Roles.Add(model);
            _dbContext.SaveChanges();
        }
        catch(System.Exception){
            throw;
        }
    }

    public void Update(Role model)
    {
        try{
            _dbContext.Roles.Update(model);
            _dbContext.SaveChanges();
        }
        catch(System.Exception){
            throw;
        }
    }
    public void Delete(Role model)
    {
        try{
            _dbContext.Roles.Update(model);
            _dbContext.SaveChanges();
        }
        catch(System.Exception){
            throw;
        }
    }
}
