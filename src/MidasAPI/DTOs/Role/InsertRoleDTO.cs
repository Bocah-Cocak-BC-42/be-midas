using System.ComponentModel.DataAnnotations;
using MidasAPI.Validations.Role;

namespace MidasAPI.DTOs.Role;

public class InsertRoleDTO
{   
    [UniqueRoleInsertNameValidation]
    [Required(ErrorMessage = "Nama jabatan tidak boleh kosong!")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "Nama jabatan harus berupa karakter!")]
    public string Name { get; set; } = null!;
}
