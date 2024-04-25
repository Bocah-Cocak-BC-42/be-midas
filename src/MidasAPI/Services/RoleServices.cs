using Azure.Core.Pipeline;
using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

public class RoleServices
{
    private readonly IRoleRepository roleRepository;

    public RoleServices(IRoleRepository roleRepository)
    {
        this.roleRepository = roleRepository;
    }


    public IndexRoleDTO GetRoles(){
        var model = roleRepository
            .GetRoles()
            .Select(role => new RoleDTO(){
                Id = role.Id,
                Name = role.Name,
                CreatedAt = role.CreatedAt,
                UpdatedAt = role.UpdatedAt,
                DeletedAt = role.DeletedAt
            });

        return new IndexRoleDTO(){
            Roles = model.ToList()
        };
    }



    public IndexRoleDTO GetRoles(int page, int pageSize){
        var model = roleRepository
            .GetRoles(page, pageSize)
            .Select(role => new RoleDTO(){
                Id = role.Id,
                Name = role.Name,
                CreatedAt = role.CreatedAt,
                UpdatedAt = role.UpdatedAt,
                DeletedAt = role.DeletedAt
            });

        return new IndexRoleDTO(){
            Roles = model.ToList(),
            Pagination = new PaginationDTO(){
                Page = page,
                PageSize = pageSize,
                TotalData = roleRepository.CountData()
            }
        };
    }

    

    public int CountData() => roleRepository.CountData();

    public void Insert(string roleName){
        
        var model = new Role(){
            Id = Guid.NewGuid().ToString(),
            Name = roleName,
            CreatedAt = DateTime.Now
        };

        roleRepository.Insert(model);

    }
    


    public void Update(UpdateRoleDTO dto){
        var model = roleRepository.GetRoleById(dto.Id);
        model.Name = dto.Name;
        model.UpdatedAt = DateTime.Now;

        roleRepository.Update(model);
    }


    public void Delete(string roleId){
        var model = roleRepository.GetRoleById(roleId);
        model.DeletedAt = DateTime.Now;

        roleRepository.Delete(model);
    }

}
