using Azure.Core.Pipeline;
using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

public class RoleServices
{
    private readonly IRoleRepository _roleRepository;

    public RoleServices(IRoleRepository _roleRepository)
    {
        this._roleRepository = _roleRepository;
    }

    public IndexRoleDTO GetRoles(){
        var model = _roleRepository
            .GetRoles()
            .Select(role => new RoleDTO(){
                Id = role.Id,
                Name = role.Name
            });

        return new IndexRoleDTO{
            Roles = model.ToList()
        };
    }


    public IndexRoleDTO GetRoles(int page, int pageSize, string roleName){
        var model = _roleRepository
            .GetRoles(page, pageSize, roleName)
            .Select(role => new RoleDTO(){
                Id = role.Id,
                Name = role.Name,
            });

        return new IndexRoleDTO(){
            Roles = model.ToList(),
            Pagination = new PaginationDTO(){
                Page = page,
                PageSize = pageSize,
                TotalData = _roleRepository.CountData(roleName)
            }
        };
    }
    

    public int CountData(string roleName) => _roleRepository.CountData(roleName);

    public void Insert(InsertRoleDTO dto){
        
        var model = new Role(){
            Id = Guid.NewGuid().ToString(),
            Name = dto.Name,
            CreatedAt = DateTime.Now
        };

        _roleRepository.Insert(model);

    }
    

    public void Update(UpdateRoleDTO dto){
        var model = _roleRepository.GetRoleById(dto.Id);
        model.Name = dto.Name;
        model.UpdatedAt = DateTime.Now;

        _roleRepository.Update(model);
    }


    public void Delete(string roleId){
        var model = _roleRepository.GetRoleById(roleId);
        model.DeletedAt = DateTime.Now;

        _roleRepository.Delete(model);
    }

}
