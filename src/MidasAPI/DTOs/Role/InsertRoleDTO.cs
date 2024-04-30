using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.Role;

public class InsertRoleDTO
{   
    [Required(ErrorMessage = "Nama jabatan tidak boleh kosong!")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "Nama jabatan harus berupa karakter!")]
    public string Name { get; set; } = null!;
}
