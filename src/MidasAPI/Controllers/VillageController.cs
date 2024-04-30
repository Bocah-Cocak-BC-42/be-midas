using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.Village;
using MidasAPI.Services;

namespace MidasAPI.Controllers;
[Authorize]
[ApiController]
[Route("api/v1/village")]
public class VillageController : ControllerBase
{
    private readonly VillageServices _service;

    public VillageController(VillageServices service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult Get(int pageNumber, int pageSize, string subdistrictId, string name = "")
    {
        try
        {
            var villages = _service.Get(pageNumber, pageSize, subdistrictId, name);
            if (villages.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kelurahan/desa"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseWithPaginationDTO<List<VillageResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("kelurahan/desa"),
                Status = ConstantConfigs.STATUS_OK,
                Data = villages,
                Pagination = new PaginationDTO()
                {
                    Page = pageNumber,
                    PageSize = pageSize,
                    TotalData = _service.Count(name, subdistrictId),
                }
            }
            );
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

    [HttpGet("{subdistrictId}")]
    public IActionResult Get(string subdistrictId)
    {
        try
        {
            var villages = _service.Get(subdistrictId);
            if (villages.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kelurahan/desa"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }
            return Ok(new ResponseDTO<List<VillageResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("kelurahan/desa"),
                Status = ConstantConfigs.STATUS_OK,
                Data = villages
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
    public IActionResult Insert(VillageInsertDTO model)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value ?? string.Empty;
            _service.Insert(model, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("kelurahan/desa"),
                Status = ConstantConfigs.STATUS_OK
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

    [HttpPut("{id}")]
    public IActionResult Update(VillageUpdateDTO model)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value ?? string.Empty;
            _service.Update(model, userId);
            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("kelurahan/desa"),
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
                Message = ConstantConfigs.MESSAGE_DELETE("kelurahan/desa"),
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
