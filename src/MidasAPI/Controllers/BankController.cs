using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;
[ApiController]
[Route("api/v1/bank")]

public class BankController : ControllerBase
{
    private readonly BankService _service;

    public BankController(BankService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get(int page, int pageSize, string name="")
    {
        try
        {
            var res = _service.Get(page, pageSize, name);
            if (res.Count == 0)
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("bank"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseWithPaginationDTO<List<BankResponseDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("bank"),
                Status = ConstantConfigs.STATUS_OK,
                Data = res,
                Pagination = new PaginationDTO(){
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountData(name),
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
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("bank"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseDTO<List<BankResponseDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("bank"),
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
        try
        {
            var res = _service.Get(id);
            if (res is null)
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("bank"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });

            return Ok(new ResponseDTO<BankResponseDTO>(){
                Message = ConstantConfigs.MESSAGE_GET("bank"),
                Status = ConstantConfigs.STATUS_OK,
                Data = new BankResponseDTO(){
                    Id = res.Id,
                    Name = res.Name
                },
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
    public IActionResult Insert([FromBody] BankInsertDTO req)
    {
        try
        {
            _service.Insert(req);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_POST("bank"),
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
    public IActionResult Update([FromBody] BankUpdateDTO req)
    {
        try
        {
            _service.Update(req);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("bank"),
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
                Message = ConstantConfigs.MESSAGE_DELETE("bank"),
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
