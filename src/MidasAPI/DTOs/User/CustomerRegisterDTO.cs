using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using MidasAPI.Validations.User;

namespace MidasAPI.DTOs.User
{
    public class CustomerRegisterDTO
    {
        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [UniqueEmailValidation]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage ="{0} tidak boleh terdapat angka")]
        [Display(Name ="Nama Lengkap")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} tidak boleh terdapat angka")]
        [Display(Name = "Nama Panggilan")]
        public string NickName { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Range(1, Int64.MaxValue, ErrorMessage ="{0} harus berupa angka")]
        [UniqueIdNumberValidation]
        [Display(Name = "NIK")]
        public string IdentityNumber { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[MFmf]*$", ErrorMessage = "Input {0} hanya boleh M/F")]
        [Length(1, 1, ErrorMessage = "Input {0} hanya boleh M/F")]
        [Display(Name = "Jenis Kelamin")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} tidak boleh berupa angka")]
        [Display(Name = "Tempat Lahir")]
        public string BirthPlace { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [BirthDateValidation]
        [Display(Name = "Tanggal Lahir")]
        public DateOnly? BirthDate { get; set; }

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Range(1, Int64.MaxValue, ErrorMessage = "{0} harus berupa angka")]
        [UniquePhoneNumberValidation]
        [Display(Name = "Nomor Telepon")]
        public string PhoneNumber { get; set; } = null!;
    }
}
