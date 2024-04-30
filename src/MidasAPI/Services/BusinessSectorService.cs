﻿using MidasAPI.DTOs.BusinessSector;
using MidasBussines;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class BusinessSectorService
{
    private readonly IBusinessSectorRepository _sectorRep;

    public BusinessSectorService(IBusinessSectorRepository sectorRep)
    {
        _sectorRep = sectorRep;
    }
    public List<BusinessSectorResponseDTO> Get(int page, int pageSize, string name) =>
        _sectorRep.Get(page,pageSize,name)
        .Select(sector => new BusinessSectorResponseDTO
        {
            Id = sector.Id,
            Name = sector.Name
        })
        .ToList();
    public List<BusinessSectorResponseDTO> Get() =>
        _sectorRep.Get()
            .Select(sector => new BusinessSectorResponseDTO
            {
                Id = sector.Id,
                Name = sector.Name
            })
            .ToList();
    public int CountData(string name) =>
        _sectorRep.CountData(name);

    public BusinessSector? Get(string id) => 
        _sectorRep.Get(id);

    public void Insert(BusinessSectorInsertDTO req) =>
        _sectorRep.Insert(new BusinessSector
            {
                Id = Guid.NewGuid().ToString(),
                Name = req.Name,
                CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
                CreatedAt = DateTime.Now
            }     
        );
    
    public void Update(BusinessSectorUpdateDTO req)
    {
        var model = _sectorRep.Get(req.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("sektor usaha"));
        model.Name = req.Name;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        _sectorRep.Update(model); 
    }

    public void Delete(string id)
    {
        var model = _sectorRep.Get(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("sektor usaha"));
        model.DeletedAt = DateTime.Now;
        model.DeletedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        _sectorRep.Update(model); 
    }

}
