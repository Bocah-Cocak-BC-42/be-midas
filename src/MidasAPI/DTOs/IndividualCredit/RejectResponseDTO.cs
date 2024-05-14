using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.IndividualCredit
{
    public class RejectResponseDTO
    {
        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        public string Notes { get; set; } = null!;
    }
}
