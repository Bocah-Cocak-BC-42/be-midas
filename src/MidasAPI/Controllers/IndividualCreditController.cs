using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTO.IndividualCredit;
using MidasAPI.DTOs.IndividualCredit;
using MidasAPI.Services;
using System.Net.NetworkInformation;
using System.Security.Claims;
using static Azure.Core.HttpHeader;

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
            var userId = User.FindFirst("userId")?.Value ?? string.Empty;

            if (request.EmergencyContacts.Count() < 2)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Minimal menyertakan 2 Kontak Darurat",
                    Status = ConstantConfigs.STATUS_FAILED
                });
            }
            if (request.FamilyCardNumber.Length != 16)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nomor Kartu Keluarga harus berupa 16 digit angka",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = request.FamilyCardNumber
                });
            }
            else if (request.BusinessPhoneNumber.Length < 10 ||
                    request.BusinessPhoneNumber.Length > 13)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nomor telepon harus berjumlah 10-13 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = request.BusinessPhoneNumber
                });
            }
            if (request.BusinessPlaceStatus != "Kontrak" && request.BusinessPlaceStatus != "Milik Pribadi"
                    && request.BusinessPlaceStatus != "Belum ada")
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Status tempat usaha harus Kontrak, Milik Pribadi, atau Belum ada",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = request.BusinessPlaceStatus
                });
            }
            bool anyECInvalidPhoneNumber = false;
            bool anyECInvalidRelative = false;
            List<EmergencyContactDTO> invalidEmergencyContactsPhoneNumber = new List<EmergencyContactDTO>();
            List<EmergencyContactDTO> invalidEmergencyContactsRelative = new List<EmergencyContactDTO>();
            foreach (var contact in request.EmergencyContacts)
            {
                if (contact.PhoneNumber.Length < 10 || contact.PhoneNumber.Length > 13)
                {
                    anyECInvalidPhoneNumber = true;
                    invalidEmergencyContactsPhoneNumber.Add(contact);
                }

                if (contact.Relative != "Ayah" && contact.Relative != "Ibu"
                    && contact.Relative != "Saudara Kandung")
                {
                    anyECInvalidRelative = true;
                    invalidEmergencyContactsRelative.Add(contact);
                }
            }
            if (anyECInvalidPhoneNumber == true)
            {
                return BadRequest(new ResponseDTO<List<EmergencyContactDTO>>()
                {
                    Message = "Nomor telepon kontak darurat harus berjumlah 10-13 digit",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = invalidEmergencyContactsPhoneNumber
                });
            }
            if (anyECInvalidRelative == true)
            {
                return BadRequest(new ResponseDTO<List<EmergencyContactDTO>>()
                {
                    Message = "Hubungan keluarga darurat harus Ayah, Ibu, atau Saudara kandung",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = invalidEmergencyContactsRelative
                });
            }

            _service.Insert(request, userId);

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

    [HttpGet("get-by-status")]
    public IActionResult GetByStatus(int page = 1, int pageSize = 5, string status = "")
    {
        try
        {
            var model = _service.GetByStatus(page, pageSize, status);
            return Ok(new ResponseDTO<List<IndividualCreditResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("Daftar Kredit Perseorangan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = model
            });
        }
        catch (System.Exception e)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = e.Message,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    //[HttpPost("submit-credit")]
    //public IActionResult SubmitCredit()
    //{

    //}

    [HttpPatch("reject-credit/{individualCreditId}")]
    public IActionResult RejectCredit(string individualCreditId, string notes ="")
    {
        try
        {
            _service.RejectCredit(individualCreditId, notes, 
                User.FindFirstValue("userId")??"", User.FindFirstValue(ClaimTypes.Role)??"");

            return Ok(new ResponseDTO<string>()
            {
                Message = "Kredit Ditolak",
                Status = ConstantConfigs.STATUS_OK,
                Data = individualCreditId
            });
        }
        catch (System.Exception e)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = e.Message,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpPatch("approve-credit/{individualCreditId}")]
    public IActionResult ApproveCredit(string individualCreditId)
    {
        try
        {
            _service.ApproveCredit(individualCreditId,
                User.FindFirstValue("userId") ?? "", User.FindFirstValue(ClaimTypes.Role) ?? "");

            return Ok(new ResponseDTO<string>()
            {
                Message = "Kredit Disetujui",
                Status = ConstantConfigs.STATUS_OK,
                Data = individualCreditId
            });
        }
        catch (System.Exception e)
        {
            return BadRequest(new ResponseDTO<string>()
            {
                Message = e.Message,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }
}
