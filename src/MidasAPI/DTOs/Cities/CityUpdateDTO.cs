using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class CityUpdateDTO
{
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama kabupaten/kota tidak boleh kosong")]
    public string Name { get; set; } = null!;
    public string ProvinceId { get; set; } = null!;
}
