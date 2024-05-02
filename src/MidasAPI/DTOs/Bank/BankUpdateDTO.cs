using System.ComponentModel.DataAnnotations;
using MidasAPI.Validations.Bank;
namespace MidasAPI.DTOs.Bank;

public class BankUpdateDTO
{
    [Required(ErrorMessage = "Ada kesalahan pada sistem, Id bank tidak diketahui")]
    public string Id { get; set; }=null!;
    [UniqueBankUpdateNameValidation]
    [Required(ErrorMessage = "Nama bank tidak boleh kosong")]
    public string Name { get; set; }=null!;
}
