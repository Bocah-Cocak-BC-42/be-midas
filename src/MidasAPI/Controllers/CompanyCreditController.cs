using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MidasAPI.DTOs;
using MidasAPI.DTOs.CompanyCredit;
using MidasAPI.DTOs.User;
using MidasAPI.Services;
using MidasDataAccess.Models;

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

    
    [HttpGet]
    public IActionResult Get(int page, int pageSize, string status = "", string userId = "")
    {
        try{
            var dto = _service.GetCredit(page, pageSize, status, userId);
            if(dto.Count == 0)
            {
                return NotFound(new ResponseDTO<string[]>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("Kredit Badan Usaha"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseWithPaginationDTO<List<CompanyCreditDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("Kredit Badan Usaha"),
                Status = ConstantConfigs.STATUS_OK,
                Data = dto,
                Pagination = new PaginationDTO()
                {
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountData(userId)
                }
            });
        }
        catch(System.Exception)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }


    [HttpPost]
    public IActionResult Insert(CompanyCreditInsertDTO dto)
    {
        try
        {   
            if(dto.Npwp.Length != 16){
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "NPWP Badan Usaha harus 16 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.Npwp
                });
            }
            else if(dto.CompanyName.Length > 20)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nama perusahaan hanya diperbolehkan maksimal 20 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.CompanyName
                });
            }
            else if(dto.PlaceOfEstasblishment.Length > 50)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Tempat pendirian perusahaan hanya diperbolehkan maksimal 50 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.PlaceOfEstasblishment
                });
            }
            else if(dto.EstablishRegistrationNumber.Length != 20)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nomor Akta Pendirian perusahaan harus 20 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.EstablishRegistrationNumber
                });
            }
            else if(dto.CompanyRegistrationNumber.Length != 13)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nomor Induk Berusaha harus 13 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.CompanyRegistrationNumber
                });
            }
            else if(dto.PhoneNumber.Length < 10 || dto.PhoneNumber.Length > 13)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nomor telepon harus berjumlah 10-13 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.PhoneNumber
                });
            }
            else if(dto.Address.Length > 200)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Alamat perusahaan hanya diperbolehkan maksimal 200 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.Address
                });
            }
            else if(dto.BusinessOwnerDetails.Count < 2)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Pemilik badan usaha minimal harus 2 data",
                    Status = ConstantConfigs.STATUS_FAILED
                });
            }

            else if(dto.CompanyAssets.Count < 1)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Aset perusahaa minimal harus 1 data",
                    Status = ConstantConfigs.STATUS_FAILED
                });
            }
            foreach(var business in dto.BusinessOwnerDetails)
            {
                if(business.IdentityNumber.Length != 16){
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "NIK pemilik badan usaha harus 16 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = business.IdentityNumber
                    });
                }
                else if(business.EmployeeIdentityNumber.Length != 16)
                {
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "NIP pemilik badan usaha harus 16 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = business.EmployeeIdentityNumber
                    });
                }
                else if(business.PhoneNumber.Length < 10 || business.PhoneNumber.Length > 13)
                {
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "Nomor telepon pemilik badan usaha harus berjumlah 10-13 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = business.PhoneNumber
                    });
                }
            }

            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Insert(dto, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_POST("kredit badan usaha"),
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

    [HttpPut("{id}")]
    public IActionResult Update(CompanyCreditUpdateDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Update(dto, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("company credit"),
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

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.Delete(id, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_DELETE("company credit"),
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

    [HttpPatch("apply-credit/{id}")]
    public IActionResult ApplyCredit(string id)
    {
        try
        {
            var dto = _service.ApplyCredit(id);
            return Ok(dto);
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

    [HttpPatch("verification-rejected/{id}")]
    public IActionResult VerificationRejected(CompanyCreditRejectedDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            var role = User.FindFirst(ClaimTypes.Role)?.Value??string.Empty;
            _service.VerificationRejected(dto, userId, role);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("ajukan kredit"),
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

    [HttpPatch("verification-approved/{id}")]
    public IActionResult VerificationApproved(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            var role = User.FindFirst(ClaimTypes.Role)?.Value??string.Empty;
            _service.VerificationApproved(id, userId, role);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("revisi kredit"),
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
}
