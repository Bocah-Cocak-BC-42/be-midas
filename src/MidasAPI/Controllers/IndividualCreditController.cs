using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.IndividualCredit;
using MidasAPI.Services;
using System.Security.Claims;

namespace MidasAPI.Controllers;
[Authorize]
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
            if (request.BusinessName.Length > 50)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = "Nama Usaha tidak boleh lebih dari 50 karakter",
                    Status = ConstantConfigs.STATUS_FAILED,
                    Data = request.BusinessName
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

    [HttpPut("update-individual-credit/{individualCreditId}")]
    public IActionResult Update(IndividualCreditUpdateDTO request)
    {
        try
        {
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

            _service.Update(request);

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_PUT("Draft Kredit Perseorangan"),
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

    [HttpDelete("delete-individual-credit/{individualCreditId}")]
    public IActionResult DeleteById(string individualCreditId)
    {
        try
        {
            _service.Delete(individualCreditId, User.FindFirstValue("userId") ?? "");

            return Ok(new ResponseDTO<string>()
            {
                Message = ConstantConfigs.MESSAGE_DELETE("kredit individu"),
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

    [HttpGet("get-all-credit")]
    public IActionResult GetCredit(string userId = "", string status = "", int page = 1, int pageSize = 5)
    {
        try
        {
            var model = _service.GetCredit(page, pageSize, userId, status);

            if (model.Count == 0)
                return Ok(new ResponseDTO<string>()
                {
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("Daftar Kredit Perseorangan"),
                    Status = ConstantConfigs.STATUS_OK
                });

            return Ok(new ResponseWithPaginationDTO<List<IndividualCreditResponseDTO>>()
            {
                Message = ConstantConfigs.MESSAGE_GET("Daftar Kredit Perseorangan"),
                Status = ConstantConfigs.STATUS_OK,
                Data = model,
                Pagination = new PaginationDTO()
                {
                    Page = page,
                    PageSize = pageSize,
                    TotalData = _service.CountByStatus(userId, status)
                }
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

    [HttpPost("submit-credit/{individualCreditId}")]
    public IActionResult SubmitCredit(string individualCreditId)
    {
        try
        {
            var model = _service.SubmitCredit(individualCreditId, User.FindFirstValue("userId") ?? "");

            if (model.Message != "Pengajuan Kredit Berhasil")
                return BadRequest(model);

            return Ok(model);
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


    [HttpPatch("reject-credit/{individualCreditId}")]
    public IActionResult RejectCredit(string individualCreditId, RejectResponseDTO rejectDTO)
    {
        try
        {
            _service.RejectCredit(individualCreditId, rejectDTO.Notes,
                User.FindFirstValue("userId") ?? "", User.FindFirstValue(ClaimTypes.Role) ?? "");

            return Ok(new ResponseDTO<string>()
            {
                Message = "Kredit Ditolak",
                Status = ConstantConfigs.STATUS_OK,
                Data = individualCreditId
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
