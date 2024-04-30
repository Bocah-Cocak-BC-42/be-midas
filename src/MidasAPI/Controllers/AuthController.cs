using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.Authorization;
using MidasAPI.Services;

namespace MidasAPI.Controllers;

[Route("api/v1/auth")]
[ApiController]

public class AuthController : ControllerBase
{
    private readonly AuthService _service;

    public AuthController(AuthService service)
    {
        _service = service;
    }


    [HttpPost]
    public IActionResult Post(AuthRequestDTO request){
        try{
            return Ok(_service.GetToken(request));
        }
        catch(Exception e){
            return BadRequest(new ResponseDTO<string>(){
                Message = e.Message,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }
}
