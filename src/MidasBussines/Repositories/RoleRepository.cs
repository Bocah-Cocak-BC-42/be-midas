using MidasDataAccess.Models;

namespace MidasBussines;

public class RoleRepository : IRoleRepository
{
    private readonly MidasContext dbContext;

    public RoleRepository(MidasContext dbContext)
    {
        this.dbContext = dbContext;
    }


    public List<Role> GetRoles()
    {
        var roles = dbContext.Roles;
        return roles.ToList();
    }

    public List<Role> GetRoles(int page, int pageSize){
        var roles = dbContext.Roles;
        return roles
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }


    public int CountData(){
        return dbContext.Roles.Count();
    }

    public Role GetRoleById(string roleId){
        return dbContext.Roles.Find(roleId);
    }

    public void Insert(Role model)
    {
        try{
            dbContext.Roles.Add(model);
            dbContext.SaveChanges();
        }
        catch(System.Exception){
            throw;
        }
    }

    public void Update(Role model)
    {
        try{
            dbContext.Roles.Update(model);
            dbContext.SaveChanges();
        }
        catch(System.Exception){
            throw;
        }
    }
    public void Delete(Role model)
    {
        try{
            dbContext.Roles.Update(model);
            dbContext.SaveChanges();
        }
        catch(System.Exception){
            throw;
        }
    }
}
