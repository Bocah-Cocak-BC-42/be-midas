using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTO.IndividualCredit;

public class EmergencyContactDTO
{
    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "No. Telepon Kontak Darurat")]
    public string PhoneNumber { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} hanya boleh berupa huruf")]
    [Display(Name = "Nama Kontak Darurat")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} hanya boleh berupa huruf")]
    [Display(Name = "Keterangan Hubungan Kontak Darurat")]
    public string Relative { get; set; } = null!;
}