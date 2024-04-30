using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class VillageInsertDTO
{
    [Required(ErrorMessage = "Nama kelurahan/desa tidak boleh kosong!")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Kode pos tidak boleh kosong!")]
    public string PostalCode { get; set; } = null!;
    public string SubDistrictId { get; set; } = null!;
}