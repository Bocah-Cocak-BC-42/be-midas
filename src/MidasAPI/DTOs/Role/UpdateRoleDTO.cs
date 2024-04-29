using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class UpdateRoleDTO
{   
    [Required(ErrorMessage = "Id jabatan tidak boleh kosong!")]
    public string Id { get; set; } = null!;

    [Required(ErrorMessage = "Nama jabatan tidak boleh kosong!")]
    public string Name { get; set; } = null!;
}
