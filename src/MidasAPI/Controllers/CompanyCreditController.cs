using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs;
using MidasAPI.DTOs.CompanyCredit;
using MidasAPI.DTOs.User;
using MidasAPI.Services;

namespace MidasAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/company-credit")]
public class CompanyCreditController : ControllerBase
{
    private readonly CompanyCreditService _service;

    public CompanyCreditController(CompanyCreditService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Insert(CompanyCreditInsertDTO dto)
    {
        try
        {
            UserResponseDTO user = new UserResponseDTO();
            user.IdentityNumber = User.FindFirst("userId")?.Value??string.Empty;
            _service.Insert(dto, user);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("company credit"),
                Status = ApprovalStatusConfig.DRAFT
            });
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}
