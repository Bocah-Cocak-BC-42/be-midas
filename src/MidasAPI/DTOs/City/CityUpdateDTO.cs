using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.City;

public class CityUpdateDTO
{
    [Required(ErrorMessage = "Id kabupaten/kota tidak boleh kosong")]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama kabupaten/kota tidak boleh kosong")]
    public string Name { get; set; } = null!;
}
