using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;

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
            return Unauthorized(e.Message);
        }
    }
}
