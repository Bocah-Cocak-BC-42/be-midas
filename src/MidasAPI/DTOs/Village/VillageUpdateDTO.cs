using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class VillageUpdateDTO
{
    [Required(ErrorMessage = "Id kelurahan/desa tidak boleh kosong")]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Nama kelurahan/desa tidak boleh kosong!")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Kode pos tidak boleh kosong!")]
    public string PostalCode { get; set; } = null!;
}
