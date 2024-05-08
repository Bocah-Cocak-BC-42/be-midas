using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTO.IndividualCredit;
using MidasAPI.Services;

namespace MidasAPI.Controllers;
[Authorize(Roles = "Nasabah")]
[ApiController]
[Route("api/v1/individual-credit")]

public class IndividualCreditController : ControllerBase
{
    private readonly IndividualCreditService _service;

    public IndividualCreditController(IndividualCreditService service)
    {
        _service = service;
    }

    [HttpPost("insert-individual-credit")]
    public IActionResult Insert(IndividualCreditInsertDTO request)
    {
        try
        {
            _service.Insert(request);
            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("Draft Kredit Perseorangan"),
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

    // public IActionResult Update(IndividualCreditUpdateDTO request)
    // {
    //     try
    //     {
    //         _service.Update(request);
    //         return Ok(new ResponseDTO<string>()
    //         {
    //             Message = ConstantConfigs.MESSAGE_PUT("Draft Kredit Perseorangan"),
    //             Status = ConstantConfigs.STATUS_OK
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>()
    //         {
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED
    //         });
    //     }
    // }
}
