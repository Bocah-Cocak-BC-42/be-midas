using MidasAPI.DTOs.Province;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class ProvinceService
{
    private readonly IProvinceRepository _repository;

    public ProvinceService(IProvinceRepository repository)
    {
        _repository = repository;
    }

    public List<ProvinceResponseDTO> Get(int pageNumber, int pageSize, string name)
    {
        return _repository.Get(pageNumber, pageSize, name)
        .Select(prov => new ProvinceResponseDTO()
        {
            Id = prov.Id,
            Name = prov.Name
        }).ToList();
    }

    public List<ProvinceResponseDTO> Get()
    {
        return _repository.Get()
        .Select(prov => new ProvinceResponseDTO()
        {
            Id = prov.Id,
            Name = prov.Name
        }).ToList();
    }

    public void Insert(ProvinceInsertDTO dto, string userId)
    {
        var prov = new Province()
        {
            Id = Guid.NewGuid().ToString(),
            Name = dto.Name,
            CreatedBy = userId,
            CreatedAt = DateTime.Now
        };

        _repository.Insert(prov);
    }

    public void Update(ProvinceUpdateDTO dto, string userId)
    {
        var prov = _repository.GetById(dto.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("provinsi"));
        prov.Name = dto.Name;
        prov.UpdatedBy = userId;
        prov.UpdatedAt = DateTime.Now;

        _repository.Update(prov);
    }

    public void Delete(string id, string userId)
    {
        var prov = _repository.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("provinsi"));
        prov.DeletedBy = userId;
        prov.DeletedAt = DateTime.Now;

        _repository.Update(prov);
    }

    public int Count(string name)
    {
        return _repository.Count(name);
    }
}