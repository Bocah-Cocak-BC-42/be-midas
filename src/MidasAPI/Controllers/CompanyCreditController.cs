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
    public IActionResult GetDraft(int page, int pageSize, string status = ""){
        try{
            var dto = _service.GetDraft(page, pageSize, status);
            if(dto.Count == 0){
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kredit badan usaha"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseWithPaginationDTO<List<CompanyCreditDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("kredit badan usaha"),
                Status = ConstantConfigs.STATUS_OK,
                Data = dto,
                Pagination = new PaginationDTO(){
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountData()
                }
            });
        }
        catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED,
            });
        }
    }


    [HttpGet("draft-customer")]
    public IActionResult GetDraftCustomer(int page, int pageSize){
        // try{
        //     var userId = User.FindFirst("userId")?.Value??string.Empty;

        //     var dto = _service.GetDraftPerCustomer(page, pageSize, userId);
        //     if(dto.Count == 0){
        //         return NotFound(new ResponseDTO<string[]>(){
        //             Message = ConstantConfigs.MESSAGE_NOT_FOUND("kredit badan usaha"),
        //             Status = ConstantConfigs.STATUS_NOT_FOUND,
        //             Data = Array.Empty<string>()
        //         });
        //     }

        //     return Ok(new ResponseWithPaginationDTO<List<CompanyCreditDTO>>(){
        //         Message = ConstantConfigs.MESSAGE_GET("kredit badan usaha"),
        //         Status = ConstantConfigs.STATUS_OK,
        //         Data = dto,
        //         Pagination = new PaginationDTO(){
        //             Page = page,
        //             PageSize = pageSize,
        //             TotalData = _service.CountData(userId)
        //         }
        //     });
        // }
        // catch(System.Exception){
        //     return BadRequest(new ResponseDTO<string>(){
        //         Message = ConstantConfigs.MESSAGE_FAILED,
        //         Status = ConstantConfigs.STATUS_FAILED,
        //     });
        // }

        var userId = User.FindFirst("userId")?.Value??string.Empty;

        var dto = _service.GetDraftPerCustomer(page, pageSize, userId);
        return Ok(dto);
    }


    [HttpPost]
    public IActionResult InsertDraft(CompanyCreditInsertDTO dto)
    {
        try
        {   
            if(dto.Npwp.Length != 16){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "NPWP Badan Usaha harus 16 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.Npwp
                });
            }
            else if(dto.CompanyName.Length > 20){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Nama perusahaan hanya diperbolehkan maksimal 20 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.CompanyName
                });
            }
            else if(dto.PlaceOfEstasblishment.Length > 50){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Tempat pendirian perusahaan hanya diperbolehkan maksimal 50 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.PlaceOfEstasblishment
                });
            }
            else if(dto.EstablishRegistrationNumber.Length != 20){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Nomor Akta Pendirian perusahaan harus 20 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.EstablishRegistrationNumber
                });
            }
            else if(dto.CompanyRegistrationNumber.Length != 13){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Nomor Induk Berusaha harus 13 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.CompanyRegistrationNumber
                });
            }
            else if(dto.PhoneNumber.Length < 10 || dto.PhoneNumber.Length > 13){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Nomor telepon harus berjumlah 10-13 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.PhoneNumber
                });
            }
            else if(dto.Address.Length > 200){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Alamat perusahaan hanya diperbolehkan maksimal 200 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = dto.Address
                });
            }
            else if(dto.BusinessOwnerDetails.Count < 2){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Pemilik badan usaha minimal harus 2 data",
                    Status = ConstantConfigs.STATUS_FAILED
                });
            }

            else if(dto.CompanyAssets.Count < 1){
                return BadRequest(new ResponseDTO<string>(){
                    Message = "Aset perusahaa minimal harus 1 data",
                    Status = ConstantConfigs.STATUS_FAILED
                });
            }
            foreach(var business in dto.BusinessOwnerDetails){
                if(business.IdentityNumber.Length != 16){
                    return BadRequest(new ResponseDTO<string>(){
                        Message = "NIK pemilik badan usaha harus 16 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = business.IdentityNumber
                    });
                }
                else if(business.EmployeeIdentityNumber.Length != 16){
                    return BadRequest(new ResponseDTO<string>(){
                        Message = "NIP pemilik badan usaha harus 16 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = business.EmployeeIdentityNumber
                    });
                }
                else if(business.PhoneNumber.Length < 10 || business.PhoneNumber.Length > 13){
                    return BadRequest(new ResponseDTO<string>(){
                        Message = "Nomor telepon pemilik badan usaha harus berjumlah 10-13 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = business.PhoneNumber
                    });
                }
            }

            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.InsertDraft(dto, userId);

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
    public IActionResult UpdateDraft(CompanyCreditUpdateDraftDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.UpdateDraft(dto, userId);

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
    public IActionResult DeleteDraft(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.DeleteDraft(id, userId);

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
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.ApplyCredit(id, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("ajukan kredit"),
                Status = ApprovalStatusConfig.WAITING_VERIFICATION_PERSONAL_DATA
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

    [HttpPatch("credit-rejected/{id}")]
    public IActionResult CreditRejected(CompanyCreditDraftRejectedDTO dto)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.CreditRejected(dto, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("ajukan kredit"),
                Status = ApprovalStatusConfig.REJECTED_FILES
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

    [HttpPatch("credit-approved/{id}")]
    public IActionResult CreditApproved(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.CreditApproved(id, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("revisi kredit"),
                Status = ApprovalStatusConfig.WAITING_VERIFICATION_MANAGER
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

    [HttpPatch("final-verification-rejected/{id}")]
    public IActionResult FinalVerificationRejected(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.FinalVerificationRejected(id, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("revisi kredit"),
                Status = ApprovalStatusConfig.REJECTED
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

    [HttpPatch("final-verification-approved/{id}")]
    public IActionResult FinalVerificationApproved(string id)
    {
        try
        {
            var userId = User.FindFirst("userId")?.Value??string.Empty;
            _service.FinalVerificationApproved(id, userId);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("revisi kredit"),
                Status = ApprovalStatusConfig.APPROVED
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
