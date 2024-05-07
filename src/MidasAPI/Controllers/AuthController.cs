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
            var model = _service.GetToken(request);
            if(model.Token == null){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Email atau Password salah!",
                    Status = ConstantConfigs.STATUS_FAILED
                });
            }

            return Ok(model);
        }
        catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }
}
