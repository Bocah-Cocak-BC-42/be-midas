using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

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

    public void Insert(ProvinceInsertDTO dto)
    {
        var prov = new Province()
        {
            Id = Guid.NewGuid().ToString(),
            Name = dto.Name,
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874", // sementara
            CreatedAt = DateTime.Now
        };

        _repository.Insert(prov);
    }

    public void Update(ProvinceUpdateDTO dto)
    {
        var prov = _repository.GetById(dto.Id);
        prov.Name = dto.Name;
        prov.UpdatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874"; // sementara
        prov.UpdatedAt = DateTime.Now;

        _repository.Update(prov);
    }

    public void Delete(string id)
    {
        var prov = _repository.GetById(id);
        prov.DeletedBy = "41dfada5-6c53-4c7b-8c07-89037e511874"; //sementara
        prov.DeletedAt = DateTime.Now;

        _repository.Update(prov);
    }

    public int Count(string name)
    {
        return _repository.Count(name);
    }
}