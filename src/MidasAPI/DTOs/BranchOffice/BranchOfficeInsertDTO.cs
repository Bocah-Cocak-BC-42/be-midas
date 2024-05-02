using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;
using MidasAPI.Validations.BranchOffice;

namespace MidasAPI.DTOs.BranchOffice;

public class BranchOfficeInsertDTO
{
    [UniqueBranchOfficeInsertCodeValidation]
    [Required(ErrorMessage = "Kode kantor cabang tidak boleh kosong")]
    public string Code { get; set; } = null!;
    [UniqueBranchOfficeInsertNameValidation]
    [Required(ErrorMessage = "Nama kantor cabang tidak boleh kosong")]
    public string OfficeName { get; set; } = null!;
    [Required(ErrorMessage = "Alamat kantor cabang tidak boleh kosong")]
    public string Address { get; set; } = null!;
    [Required(ErrorMessage = "Desa/Kelurahan cabang tidak boleh kosong")]
    public string VillageId { get; set; } = null!;
}
