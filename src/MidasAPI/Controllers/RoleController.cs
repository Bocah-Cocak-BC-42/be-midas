using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;

[Route("api/v1/roles")]
[ApiController]

public class RoleController : ControllerBase
{   

    private readonly RoleServices services;

    public RoleController(RoleServices services)
    {
        this.services = services;
    }


    [HttpGet("getAllRoles")]
    public IActionResult Get(){

        try{
            var dto = services.GetRoles();
            if(dto.Roles.Count == 0){
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("jabatan"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }
            
            return Ok(new ResponseWithPaginationDTO<List<RoleDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("jabatan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = dto.Roles
            });

        }
        catch(Exception e){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
        
    }


    [HttpGet("getAllRolesWithPagination")]
    public IActionResult Get(int page, int pageSize){
        try{
            var dto = services.GetRoles(page, pageSize);
            if(dto.Roles.Count == 0){
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("jabatan"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }
            
            return Ok(new ResponseWithPaginationDTO<List<RoleDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("jabatan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = dto.Roles,
                Pagination = new PaginationDTO(){
                    Page = page,
                    PageSize = pageSize,
                    TotalData = services.CountData()
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




    [HttpPost("InsertRole{roleName}")]
    public IActionResult Insert(string roleName){
        try{
            services.Insert(roleName);

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



    [HttpPut("UpdateRole")]
    public IActionResult Update([FromBody] UpdateRoleDTO dto){
        try
        {
            services.Update(dto);
            
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


    [HttpDelete("DeleteRole/{roleId}")]
    public IActionResult Delete(string roleId){
        try{
            services.Delete(roleId);

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
