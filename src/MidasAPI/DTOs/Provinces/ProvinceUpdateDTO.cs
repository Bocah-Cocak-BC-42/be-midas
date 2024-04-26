using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class ProvinceUpdateDTO
{
    [Required(ErrorMessage = "Id provinsi tidak boleh kosong")]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama provinsi tidak boleh kosong")]
    public string Name { get; set; } = null!;
}