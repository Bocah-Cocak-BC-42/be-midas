using MidasAPI.DTOs.BranchOffice;
using MidasAPI.DTOs.City;
using MidasAPI.DTOs.Province;
using MidasAPI.DTOs.Subdistrict;
using MidasAPI.DTOs.Village;
using MidasBussines;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class BranchOfficeService
{
    private readonly IBranchOfficeRepository _officeRep;
    private readonly IAssociateUserBranchRepository _associateRep;

    public BranchOfficeService(IBranchOfficeRepository officeRep, IAssociateUserBranchRepository associateRep)
    {
        _officeRep = officeRep;
        _associateRep = associateRep;
    }

    public List<BranchOfficeResponseDTO> Get(int page, int pageSize, string officeName, string province, string city) =>
        _officeRep.Get(page,pageSize,officeName,province,city)
        .Select(office=> new BranchOfficeResponseDTO
        {
            Id = office.Id,
            Code = office.OfficeCode,
            Name = office.OfficeName,
            Address = office.Address,
            Province = office.Village.SubDistrict.City.Province.Name,
            City = office.Village.SubDistrict.City.Name
        })
        .ToList();
    public List<BranchOfficeResponseDTO> Get() =>
        _officeRep.Get()
            .Select(office=> new BranchOfficeResponseDTO
        {
            Id = office.Id,
            Code = office.OfficeCode,
            Name = office.OfficeName,
            Address = office.Address,
            Province = office.Village.SubDistrict.City.Province.Name,
            City = office.Village.SubDistrict.City.Name
        })   
        .ToList();
    public int CountData(string officeName, string province, string city) =>
        _officeRep.CountData(officeName,province,city);
    public int CountDataEmployeeByOffice(string branchOfficeId, string fullName, string role)=>
        _associateRep.CountDataEmployeeByOffice(branchOfficeId,fullName,role);
    public BranchOffice? Get(string id) =>
        _officeRep.Get(id);
    public List<AssociateUserBranch> GetEmployeeByOffice(int page, int pageSize, string branchOfficeId, string fullName, string role) =>
        _associateRep.GetEmployeeByOffice(page, pageSize, branchOfficeId,fullName,role);
    public void Insert(BranchOfficeInsertDTO req, string userId) =>
        _officeRep.Insert(new BranchOffice
            {
                Id = Guid.NewGuid().ToString(),
                OfficeName = req.OfficeName,
                OfficeCode = req.Code,
                Address = req.Address,
                VillageId = req.VillageId,
                CreatedAt = DateTime.Now,
                CreatedBy = userId
            }
        );
    public void Update(BranchOfficeUpdateDTO req, string userId)
    {
        var model = _officeRep.Get(req.Id)?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"));
        model.OfficeName = req.OfficeName;
        model.OfficeCode = req.Code;
        model.Address = req.Address;
        model.VillageId = req.VillageId;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = userId;
        _officeRep.Update(model); 
        
    }
    public void Delete(string id, string userId)
    {
        var model = _officeRep.Get(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"));
        model.DeletedAt = DateTime.Now;
        model.DeletedBy = userId;
        _officeRep.Update(model);
    }
    
}