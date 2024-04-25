using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class UpdateRoleDTO
{
    public string Id { get; set; }


    [Required(ErrorMessage = "Nama jabatan tidak boleh kosong!")]
    public string Name { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
