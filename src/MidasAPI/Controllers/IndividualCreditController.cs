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
}
