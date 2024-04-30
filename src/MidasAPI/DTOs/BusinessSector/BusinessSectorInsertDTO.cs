using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.BusinessSector;

public class BusinessSectorInsertDTO
{
    [Required(ErrorMessage = "Nama sektor usaha tidak boleh kosong")]
    public string Name { get; set; }=null!;
}
