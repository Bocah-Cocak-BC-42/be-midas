using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.BusinessOwnerDetail;

public class BusinessOwnerDetailDTO
{   
    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "NIK")]
    public string IdentityNumber { get; set; } = null!;



    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "NIP")]
    public string EmployeeIdentityNumber { get; set; } = null!;



    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "{0} harus berupa karakter!")]
    [Display(Name = "Nama Lengkap")]
    public string FullName { get; set; } = null!;


    
    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "{0} harus berupa karakter!")]
    [Display(Name = "Jabatan")]
    public string Position { get; set; } = null!;


    
    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage ="{0} harus berupa angka")]
    [Display(Name = "Nomor Telepon")]
    public string PhoneNumber { get; set; } = null!;
}
