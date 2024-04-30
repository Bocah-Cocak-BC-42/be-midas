using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;
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
    public IActionResult Post(VillageInsertDTO model)
    {
        try
        {
            _service.Insert(model);

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
            _service.Update(model);
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
            _service.Delete(id);
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
