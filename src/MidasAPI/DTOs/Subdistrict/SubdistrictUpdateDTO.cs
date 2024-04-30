using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.Subdistrict;

public class SubdistrictUpdateDTO
{
    [Required(ErrorMessage = "Id kecamatan tidak boleh kosong")]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama kecamatan tidak boleh kosong!")]
    public string Name { get; set; } = null!;
}
