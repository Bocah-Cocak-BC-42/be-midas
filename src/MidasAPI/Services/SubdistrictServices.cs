using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

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

    public void Insert(SubdistrictInsertDTO model)
    {
        var dto = new SubDistrict()
        {
            Id = Guid.NewGuid().ToString(),
            Name = model.Name,
            CityId = model.CityId,
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        };
        _repo.Insert(dto);
    }

    public void Update(SubdistrictUpdateDTO model)
    {
        var subdistrict = _repo.GetById(model.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kecamatan"));
        subdistrict.Name = model.Name;
        subdistrict.UpdatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        subdistrict.UpdatedAt = DateTime.Now;

        _repo.Update(subdistrict);
    }

    public void Delete(string id)
    {
        var subdistrict = _repo.GetById(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kecamatan"));
        subdistrict.DeletedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        subdistrict.DeletedAt = DateTime.Now;
        _repo.Update(subdistrict);
    }

    public int Count(string name, string cityId)
    {
        return _repo.Count(name, cityId);
    }
}
