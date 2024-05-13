using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.BranchOffice;
using MidasAPI.DTOs.User;
using MidasAPI.Services;

namespace MidasAPI.Controllers;
[Authorize]
[ApiController]
[Route("api/v1/branch-office")]
public class BranchOfficeController : ControllerBase
{
    private readonly BranchOfficeService _service;

    public BranchOfficeController(BranchOfficeService service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult Get(int page, int pageSize, string officeName="", string province="", string city="")
    {
        try
        {
            var res = _service.Get(page, pageSize, officeName, province, city);
            if (res.Count == 0)
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseWithPaginationDTO<List<BranchOfficeResponseDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("kantor cabang"),
                Status = ConstantConfigs.STATUS_OK,
                Data = res,
                Pagination = new PaginationDTO(){
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountData(officeName,province,city)
                }
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }

    }
    [HttpGet("all")]
    public IActionResult Get()
    {
        try
        {
            var res = _service.Get();
            if (res.Count == 0)
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseDTO<List<BranchOfficeResponseDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("kantor cabang"),
                Status = ConstantConfigs.STATUS_OK,
                Data = res,
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }
    [HttpGet("{id}")]
    public IActionResult GetDetail(string id, int page, int pageSize, string fullName="", string role="")
    {
        var resOffice = _service.Get(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"));
        var resEmployee = _service.GetEmployeeByOffice(page,pageSize,id,fullName,role);
        List<UserDetailDTO> employees = new List<UserDetailDTO>();  
        foreach (var associate in resEmployee)
        {
            var employee = new UserDetailDTO(){
                Id = associate.User.Id,
                FullName = associate.User.FullName,
                IdentityNumber = associate.User.IdentityNumber,
                RoleName = associate.User.Role.Name,
            };
            employees.Add(employee);
        }
        
        if (resOffice is null )
            return NotFound(new ResponseDTO<string[]>(){
                Message = ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"),
                Status = ConstantConfigs.STATUS_NOT_FOUND,
                Data = Array.Empty<string>()
            });

        return Ok(new ResponseWithPaginationDTO<BranchOfficeResponseDetailDTO>(){
            Message = ConstantConfigs.MESSAGE_GET("kantor cabang"),
            Status = ConstantConfigs.STATUS_OK,
            Data = new BranchOfficeResponseDetailDTO(){
                Id = resOffice.Id,
                Name = resOffice.OfficeName,
                Code = resOffice.OfficeCode,
                Province = resOffice.Village.SubDistrict.City.ProvinceId,
                City = resOffice.Village.SubDistrict.CityId,
                SubDistrict = resOffice.Village.SubDistrictId,
                Address = resOffice.Address,
                Village = resOffice.VillageId,
                PostalCode = resOffice.Village.PostalCode,
                Employees = employees.ToList()
            },
            Pagination = new PaginationDTO(){
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountDataEmployeeByOffice(id,fullName,role)
            }
        });
    }
    [HttpPost]
    public IActionResult Insert([FromBody] BranchOfficeInsertDTO req)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Insert(req,userId);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_POST("kantor cabang"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }   
    }
    [HttpPut("{id}")]
    public IActionResult Update([FromBody] BranchOfficeUpdateDTO req)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Update(req,userId);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("kantor cabang"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Delete(id,userId);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_DELETE("kantor cabang"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    } 
}
