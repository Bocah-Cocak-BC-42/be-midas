using System.ComponentModel.DataAnnotations;
using MidasAPI.Validations.BusinessSector;

namespace MidasAPI.DTOs.BusinessSector;

public class BusinessSectorInsertDTO
{
    [UniqueBusinessSectorInsertNameValidation]
    [Required(ErrorMessage = "Nama sektor usaha tidak boleh kosong")]
    public string Name { get; set; }=null!;
}
