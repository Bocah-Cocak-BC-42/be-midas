using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.Province;
using MidasAPI.Services;

namespace MidasAPI.Controllers;

[ApiController]
[Route("api/v1/province")]
public class ProvinceController : ControllerBase
{
    private readonly ProvinceService _service;

    public ProvinceController(ProvinceService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get(int pageNumber, int pageSize, string name = "")
    {
        try
        {
            var prov = _service.Get(pageNumber, pageSize, name);
            if (prov.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("provinsi"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseWithPaginationDTO<List<ProvinceResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("provinsi"),
                Status = ConstantConfigs.STATUS_OK,
                Data = prov,
                Pagination = new PaginationDTO()
                {
                    Page = pageNumber,
                    PageSize = pageSize,
                    TotalData = _service.Count(name)
                }
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpGet("all")]
    public IActionResult Get()
    {
        try
        {
            var prov = _service.Get();
            if (prov.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("provinsi"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseDTO<List<ProvinceResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("provinsi"),
                Status = ConstantConfigs.STATUS_OK,
                Data = prov
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpPost]
    public IActionResult Insert(ProvinceInsertDTO dto)
    {
        try
        {
            _service.Insert(dto);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("provinsi"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpPut("{id}")]
    public IActionResult Update(ProvinceUpdateDTO dto)
    {
        try
        {
            _service.Update(dto);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("provinsi"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        try
        {
            _service.Delete(id);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_DELETE("provinsi"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }
}
