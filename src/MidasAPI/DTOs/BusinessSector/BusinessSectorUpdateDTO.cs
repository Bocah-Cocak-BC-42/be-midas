using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.BusinessSector;

public class BusinessSectorUpdateDTO
{
    [Required(ErrorMessage = "Ada kesalahan pada sistem, Id sektor usaha tidak diketahui")]
    public string Id { get; set; }=null!;
    [Required(ErrorMessage = "Nama sektor usaha tidak boleh kosong")]
    public string Name { get; set; }=null!;
}
