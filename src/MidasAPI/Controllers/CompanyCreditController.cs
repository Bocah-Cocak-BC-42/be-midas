using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

    // [HttpPost]
    // public IActionResult Insert(CompanyCreditInsertDTO dto)
    // {
    //     try
    //     {
            
    //     }
    //     catch (System.Exception)
    //     {
            
    //         throw;
    //     }
    // }
}
