using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.Subdistrict;

public class SubdistrictInsertDTO
{
    [Required(ErrorMessage = "Nama kelurahan/desa tidak boleh kosong!")]
    public string Name { get; set; } = null!;
    public string CityId { get; set; } = null!;
}
