using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.AssociateUserBranch;
using MidasAPI.Services;

namespace MidasAPI.Controllers;
[Authorize]
[ApiController]
[Route("api/v1/associate-user-branch")]
public class AssociateUserBranchController : ControllerBase
{
    private readonly AssociateUserBranchService _service;

    public AssociateUserBranchController(AssociateUserBranchService service)
    {
        _service = service;
    }
    [HttpGet("all")]
    public IActionResult Get()
    {   
        try
        {
            var res = _service.Get();
            if (res.Count == 0)
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("asosiasi karyawan dan kantor cabang"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseDTO<List<AssociateUserBranchResponseDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("asosiasi karyawan dan kantor cabang"),
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
    [HttpPost]
    public IActionResult Insert([FromBody] AssociateUserBranchInsertDTO req)
    {
        try
        {
            _service.Insert(req);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_POST("asosiasi karyawan dan kantor cabang"),
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
    public IActionResult Update([FromBody] AssociateUserBranchUpdateDTO req)
    {
        try
        {
            _service.Update(req);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("asosiasi karyawan dan kantor cabang"),
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
            _service.Delete(id);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_DELETE("asosiasi karyawan dan kantor cabang"),
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
