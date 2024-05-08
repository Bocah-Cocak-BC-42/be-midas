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
    public IActionResult GetDetail(string id)
    {
        // try
        // {
            var res = _service.Get(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"));
            List<UserDetailDTO> employees = new List<UserDetailDTO>();  
            foreach (var user in res.AssociateUserBranches.ToList())
            {
                var employee = new UserDetailDTO(){
                    Id = user.User.Id,
                    FullName = user.User.FullName,
                    IdentityNumber = user.User.IdentityNumber,
                    RoleName = user.User.Role.Name,
                };
                employees.Add(employee);
            }
            
            if (res is null)
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kantor cabang"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseDTO<BranchOfficeResponseDetailDTO>(){
                Message = ConstantConfigs.MESSAGE_GET("kantor cabang"),
                Status = ConstantConfigs.STATUS_OK,
                Data = new BranchOfficeResponseDetailDTO(){
                    Id = res.Id,
                    Name = res.OfficeName,
                    Code = res.OfficeCode,
                    Province = res.Village.SubDistrict.City.ProvinceId,
                    City = res.Village.SubDistrict.CityId,
                    SubDistrict = res.Village.SubDistrictId,
                    Address = res.Address,
                    Village = res.VillageId,
                    PostalCode = res.Village.PostalCode,
                    Employees = employees.ToList()
                },
            });
        // }

        // catch (System.Exception)
        // {
        //     return BadRequest(new ResponseDTO<string>(){
        //         Message = ConstantConfigs.MESSAGE_FAILED,
        //         Status = ConstantConfigs.STATUS_FAILED,
        //     });
        // }  
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
