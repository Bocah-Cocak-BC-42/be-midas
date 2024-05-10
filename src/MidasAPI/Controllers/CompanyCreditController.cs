﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

    [HttpGet("company-type")]
    public IActionResult GetCompanyTypes()
    {
        try
        {
            var companyType = _service.GetCompanyTypes();
            if (companyType.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("company type"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseDTO<List<SelectListItem>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("provinsi"),
                Status = ConstantConfigs.STATUS_OK,
                Data = companyType
            });
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    [HttpPost("draft")]
    public IActionResult Insert(CompanyCreditInsertDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Insert(dto, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("company credit"),
                Status = ApprovalStatusConfig.DRAFT
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
