using Microsoft.AspNetCore.Authorization;
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


    [HttpGet]
    public IActionResult GetDraft(int page, int pageSize){
        try{
            var dto = _service.GetDraft(page, pageSize);
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
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("jenis perusahaan"),
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
}
