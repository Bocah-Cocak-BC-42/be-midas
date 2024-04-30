using MidasAPI.DTOs.City;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class CityService
{
    private readonly ICityRepository _repository;

    public CityService(ICityRepository repository)
    {
        _repository = repository;
    }

    public List<CityResponseDTO> Get(int pageNumber, int pageSize, string name, string provinceId)
    {
        return _repository.Get(pageNumber, pageSize, name, provinceId)
        .Select(city => new CityResponseDTO()
        {
            Id = city.Id,
            Name = city.Name
        }).ToList();
    }

    public List<CityResponseDTO> Get(string provinceId)
    {
        return _repository.Get(provinceId)
        .Select(city => new CityResponseDTO()
        {
            Id = city.Id,
            Name = city.Name
        }).ToList();
    }

    public void Insert(CityInsertDTO dto)
    {
        var city = new City()
        {
            Id = Guid.NewGuid().ToString(),
            Name = dto.Name,
            ProvinceId = dto.ProvinceId,
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        };

        _repository.Insert(city);
    }

    public void Update(CityUpdateDTO dto)
    {
        var city = _repository.GetById(dto.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kota"));
        city.Name = dto.Name;
        city.UpdatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        city.UpdatedAt = DateTime.Now;

        _repository.Update(city);
    }

    public void Delete(string id)
    {
        var city = _repository.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kota"));
        city.DeletedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        city.DeletedAt = DateTime.Now;

        _repository.Update(city);
    }

    public int Count(string name, string provinceId)
    {
        return _repository.Count(name, provinceId);
    } 
}
