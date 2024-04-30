using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.Province;

public class ProvinceInsertDTO
{
    [Required(ErrorMessage = "Nama provinsi tidak boleh kosong")]
    public string Name { get; set; } = null!;
}