using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class InsertRoleDTO
{   
    [Required(ErrorMessage = "Nama jabatan tidak boleh kosong!")]
    public string Name { get; set; } = null!;
}
