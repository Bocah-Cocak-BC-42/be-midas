using System.ComponentModel.DataAnnotations;

namespace MidasAPI;

public class BankUpdateDTO
{
    [Required(ErrorMessage = "Ada kesalahan pada sistem, Id bank tidak diketahui")]
    public string Id { get; set; }
    [Required(ErrorMessage = "Nama bank tidak boleh kosong")]
    public string Name { get; set; }
}
