using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.Bank;

public class BankInsertDTO
{
    [Required(ErrorMessage = "Nama bank tidak boleh kosong")]
    public string Name { get; set; }=null!;
}
