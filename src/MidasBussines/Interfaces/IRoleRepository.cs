using MidasDataAccess.Models;

namespace MidasBussines;

public interface IRoleRepository
{
    public List<Role> GetRoles();
    public List<Role> GetRoles(int page, int pageSize, string roleName);
    public int CountData(string roleName);
    public Role GetRoleById(string roleId);
    public void Insert(Role model);
    public void Update(Role model);
    public void Delete(Role model);
}
