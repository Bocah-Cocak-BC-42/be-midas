using MidasAPI.DTOs.Role;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class RoleServices
{
    private readonly IRoleRepository _roleRepository;

    public RoleServices(IRoleRepository _roleRepository)
    {
        this._roleRepository = _roleRepository;
    }

    public List<RoleDTO> GetRoles(){
        var model = _roleRepository
            .GetRoles()
            .Select(role => new RoleDTO(){
                Id = role.Id,
                Name = role.Name
            });

        return model.ToList();
    }


    public List<RoleDTO> GetRoles(int page, int pageSize, string roleName){
        var model = _roleRepository
            .GetRoles(page, pageSize, roleName)
            .Select(role => new RoleDTO(){
                Id = role.Id,
                Name = role.Name,
            });

        return model.ToList();
    }
    
    public Role GetRoleById(string id){
        var model = _roleRepository.GetRoleById(id);
        return model;
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
        var model = _roleRepository.GetRoleById(dto.Id) ?? throw new NullReferenceException("");
        model.Name = dto.Name;
        model.UpdatedAt = DateTime.Now;

        _roleRepository.Update(model);
    }


    public void Delete(string roleId){
        var model = _roleRepository.GetRoleById(roleId) ?? throw new NullReferenceException("");
        model.DeletedAt = DateTime.Now;

        _roleRepository.Delete(model);
    }

}
