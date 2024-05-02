using MidasAPI.DTOs.Subdistrict;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class SubdistrictServices
{
    private readonly ISubdistrictRepository _repo;

    public SubdistrictServices(ISubdistrictRepository repo)
    {
        _repo = repo;
    }

    public List<SubdistrictrResponseDTO> Get(int page, int pageSize, string cityId, string name = "")
    {
        var models = _repo.Get(page, pageSize, cityId, name);
        return models.Select(dto => new SubdistrictrResponseDTO()
        {
            Id = dto.Id,
            Name = dto.Name
        }).ToList();
    }

    public List<SubdistrictrResponseDTO> Get(string cityId)
    {
        var models = _repo.Get(cityId);
        return models.Select(dto => new SubdistrictrResponseDTO()
        {
            Id = dto.Id,
            Name = dto.Name
        }).ToList();
    }

    public void Insert(SubdistrictInsertDTO model, string userId)
    {
        var dto = new SubDistrict()
        {
            Id = Guid.NewGuid().ToString(),
            Name = model.Name,
            CityId = model.CityId,
            CreatedBy = userId,
            CreatedAt = DateTime.Now
        };
        _repo.Insert(dto);
    }

    public void Update(SubdistrictUpdateDTO model, string userId)
    {
        var subdistrict = _repo.GetById(model.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kecamatan"));
        subdistrict.Name = model.Name;
        subdistrict.UpdatedBy = userId;
        subdistrict.UpdatedAt = DateTime.Now;

        _repo.Update(subdistrict);
    }

    public void Delete(string id, string userId)
    {
        var subdistrict = _repo.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kecamatan"));
        subdistrict.DeletedBy = userId;
        subdistrict.DeletedAt = DateTime.Now;
        _repo.Update(subdistrict);
    }

    public int Count(string name, string cityId)
    {
        return _repo.Count(name, cityId);
    }
}
