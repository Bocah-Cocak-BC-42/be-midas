using System.ComponentModel.DataAnnotations;
using MidasAPI.DTOs.City;
using MidasAPI.DTOs.Province;
using MidasAPI.DTOs.Village;
using MidasDataAccess.Models;

namespace MidasAPI.DTOs.BranchOffice;

public class BranchOfficeUpdateDTO
{
    [Required(ErrorMessage = "Ada kesalahan pada sistem, Id kantor cabang tidak terdefinisi")]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama kantor cabang tidak boleh kosong")]
    public string OfficeName { get; set; } = null!;
    [Required(ErrorMessage = "Kode kantor cabang tidak boleh kosong")]
    public string Code { get; set; } = null!;
    [Required(ErrorMessage = "Alamat kantor cabang tidak boleh kosong")]
    public string Address { get; set; } = null!;
    [Required(ErrorMessage = "Desa/Kelurahan cabang tidak boleh kosong")]
    public string VillageId { get; set; } = null!;
}