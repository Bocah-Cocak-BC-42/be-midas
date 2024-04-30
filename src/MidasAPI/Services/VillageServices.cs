using MidasAPI.DTOs.Village;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class VillageServices
{
    private readonly IVillageRepository _repo;

    public VillageServices(IVillageRepository repo)
    {
        _repo = repo;
    }

    public List<VillageResponseDTO> Get(int page, int pageSize, string subDistrictId, string name = "")
    {
        var models = _repo.Get(page, pageSize, subDistrictId, name);
        return models.Select(dto => new VillageResponseDTO()
        {
            Id = dto.Id,
            Name = dto.Name,
            PostalCode = dto.PostalCode
        }).ToList();
    }

    public List<VillageResponseDTO> Get(string subDistrictId)
    {
        var models = _repo.Get(subDistrictId);
        return models.Select(dto => new VillageResponseDTO()
        {
            Id = dto.Id,
            Name = dto.Name,
            PostalCode = dto.PostalCode
        }).ToList();
    }

    public void Insert(VillageInsertDTO model, string userId)
    {
        var dto = new Village()
        {
            Id = Guid.NewGuid().ToString(),
            Name = model.Name,
            SubDistrictId = model.SubDistrictId,
            PostalCode = model.PostalCode,
            CreatedBy = userId,
            CreatedAt = DateTime.Now
        };
        _repo.Insert(dto);
    }

    public void Update(VillageUpdateDTO model, string userId)
    {
        var village = _repo.GetById(model.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kelurahan/desa"));
        village.Name = model.Name;
        village.PostalCode = model.PostalCode;
        village.UpdatedBy = userId;
        village.UpdatedAt = DateTime.Now;
        _repo.Update(village);
    }

    public void Delete(string id, string userId)
    {
        var dto = _repo.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kelurahan/desa"));
        dto.DeletedBy = userId;
        dto.DeletedAt = DateTime.Now;
        _repo.Update(dto);
    }

    public int Count(string name, string subDistrictId)
    {
        return _repo.Count(name, subDistrictId);
    }
}
