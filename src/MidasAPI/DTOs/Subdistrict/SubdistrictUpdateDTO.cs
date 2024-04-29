using System.Runtime.CompilerServices;

using System.ComponentModel.DataAnnotations;
namespace MidasAPI;

public class SubdistrictUpdateDTO
{
    [Required(ErrorMessage = "Id kecamatan tidak boleh kosong")]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama kecamatan tidak boleh kosong!")]
    public string Name { get; set; } = null!;
}
