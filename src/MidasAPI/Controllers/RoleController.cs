using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;

[Route("api/v1/roles")]
[ApiController]

public class RoleController : ControllerBase
{   

    private readonly RoleServices _service;

    public RoleController(RoleServices _service)
    {
        this._service = _service;
    }


    [HttpGet("all")]
    public IActionResult Get(){
        try{
            var dto = _service.GetRoles();
            if(dto.Count == 0){
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("jabatan"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }
            
            return Ok(new ResponseWithPaginationDTO<List<RoleDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("jabatan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = dto
            });

        }
        catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }



    [HttpGet]
    public IActionResult Get(int page, int pageSize, string roleName = ""){
        try{
            var dto = _service.GetRoles(page, pageSize, roleName);
            if(dto.Count == 0){
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("jabatan"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }
            
            return Ok(new ResponseWithPaginationDTO<List<RoleDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("jabatan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = dto,
                Pagination = new PaginationDTO(){
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountData(roleName)
                }
            });

        }
        catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }



    [HttpPost]
    public IActionResult Insert([FromBody] InsertRoleDTO dto){
        try{
            _service.Insert(dto);

            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_POST("jabatan"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }



    [HttpPut]
    public IActionResult Update([FromBody] UpdateRoleDTO dto){
        try
        {
            _service.Update(dto);
            
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("jabatan"),
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


    [HttpDelete("{roleId}")]
    public IActionResult Delete(string roleId){
        try{
            _service.Delete(roleId);

            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_DELETE("jabatan"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }


}
