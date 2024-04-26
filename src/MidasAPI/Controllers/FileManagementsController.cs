using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;

[ApiController]
[Route("api/v1/file-managements")]
public class FileManagementsController: ControllerBase
{
    private readonly FileManagementServices _service;

    public FileManagementsController(FileManagementServices service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult InsertFile([FromForm] FileInsertDTO dto){
        try
        {
            var result = new FileResponseDTO(){
                FileId = _service.Upload(dto)
            };
            return Ok(new ResponseDTO<FileResponseDTO>(){
                Message = ConstantConfigs.MESSAGE_POST(dto.FileCategory),
                Status = ConstantConfigs.STATUS_OK,
                Data = result,
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
