using System.ComponentModel.DataAnnotations;
using MidasAPI.Validations.Bank;
namespace MidasAPI.DTOs.Bank;

public class BankInsertDTO
{
    [UniqueBankInsertNameValidation]
    [Required(ErrorMessage = "Nama bank tidak boleh kosong")]
    public string Name { get; set; }=null!;
}
