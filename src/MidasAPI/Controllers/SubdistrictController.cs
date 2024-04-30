using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.Subdistrict;
using MidasAPI.Services;

namespace MidasAPI.Controllers;
[ApiController]
[Route("api/v1/subdistrict")]

public class SubdistrictController : ControllerBase
{
    private readonly SubdistrictServices _service;

    public SubdistrictController(SubdistrictServices service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get(int pageNumber, int pageSize, string cityId, string name = "")
    {
        try
        {
            var subdistricts = _service.Get(pageNumber, pageSize, cityId, name);
            if (subdistricts.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kecamatan"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseWithPaginationDTO<List<SubdistrictrResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("kecamatan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = subdistricts,
                Pagination = new PaginationDTO()
                {
                    Page = pageNumber,
                    PageSize = pageSize,
                    TotalData = _service.Count(name, cityId),
                }
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }

    [HttpGet("{cityId}")]
    public IActionResult Get(string cityId)
    {
        try
        {
            var subdistricts = _service.Get(cityId);
            if (subdistricts.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kecamatan"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }
            return Ok(new ResponseDTO<List<SubdistrictrResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("kecamatan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = subdistricts
            });
        }
        catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }

    [HttpPost]
    public IActionResult Insert(SubdistrictInsertDTO req)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value ?? string.Empty;
            _service.Insert(req, userId);
            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("kecamatan"),
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
    public IActionResult Update(SubdistrictUpdateDTO req)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value ?? string.Empty;
            _service.Update(req, userId);
            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("kecamatan"),
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
            var userId = User.FindFirst("userId")?.Value ?? string.Empty;
            _service.Delete(id, userId);
            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_DELETE("kecamatan"),
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
