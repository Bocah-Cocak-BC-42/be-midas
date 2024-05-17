using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs;

namespace MidasAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/credit-upgrade")]
public class CreditUpgradeController: ControllerBase
{
    private readonly CreditUpgradeServices _services;

    public CreditUpgradeController(CreditUpgradeServices services)
    {
        _services = services;
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        try
        {
            var creditUpgrade = _services.Get(id);
            return Ok(new ResponseDTO<CreditUpgradeResponseDTO>(){
                Message = ConstantConfigs.MESSAGE_GET("credit upgrade"),
                Status = ConstantConfigs.STATUS_OK,
                Data = creditUpgrade
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

    [Authorize(Roles ="Nasabah")]
    [HttpGet("customer")]
    public IActionResult GetCreditUpgradeCustomers()
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            var creditUpgrade = _services.GetCreditUpgradesCustomer(userId);
            return Ok(new ResponseDTO<CreditUpgradeListResDTO>(){
                Message = ConstantConfigs.MESSAGE_GET("credit upgrade"),
                Status = ConstantConfigs.STATUS_OK,
                Data = creditUpgrade,
            });
        }
        catch (System.Exception e)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = e.Message,
                // Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
        
    }

    [Authorize(Roles = "Admin, Supervisor")]
    [HttpGet]
    public IActionResult GetAllBy(int page, int size)
    {
        try
        {
            string role = User.FindFirst(ClaimTypes.Role)?.Value??string.Empty;
            var pagination = _services.CreditUpgradePagination(role, page, size);
            var creditUpgrade = _services.GetCreditUpgrades(role, page, size);
            return Ok(new ResponseWithPaginationDTO<CreditUpgradeListResDTO>(){
                Message = ConstantConfigs.MESSAGE_GET("credit upgrade"),
                Status = ConstantConfigs.STATUS_OK,
                Data = creditUpgrade,
                Pagination = pagination
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

    [Authorize(Roles ="Nasabah")]
    [HttpPost]
    public IActionResult Insert(CreditUpgradeInsertDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _services.InsertCreditUpgrade(dto, userId);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_POST("credit upgrade"),
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
    
    [Authorize(Roles ="Nasabah")]
    [HttpPut("{id}")]
    public IActionResult Edit(string id, CreditUpgradeInsertDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _services.EditCreditUpgrade(dto, id, userId);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("credit upgrade"),
                Status = ConstantConfigs.STATUS_OK
            });
        }
        catch (System.Exception e)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }

    [Authorize(Roles = "Admin, Supervisor")]
    [HttpPatch("approve")]
    public IActionResult Approve(ApproveCreditUpgradeDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            string role = User.FindFirst(ClaimTypes.Role)?.Value??string.Empty;
            _services.ApproveCreditUpgrade(userId, role, dto);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("approve credit upgrade"),
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
    [Authorize(Roles = "Admin, Supervisor")]
    [HttpPatch("reject")]
    public IActionResult Reject(RejectCreditUpgradeDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            string role = User.FindFirst(ClaimTypes.Role)?.Value??string.Empty;
            _services.RejectCreditUpgrade(dto);
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("reject credit upgrade"),
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