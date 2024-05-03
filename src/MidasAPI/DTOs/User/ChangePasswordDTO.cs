using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.User
{
    public class ChangePasswordDTO
    {
        [Required(ErrorMessage ="{0} tidak boleh kosong")]
        [Display(Name = "Password Lama")]
        public string oldPassword { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Display(Name = "Password Baru")]
        public string newPassword { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Display(Name = "Konfirmasi Password")]
        [Compare("newPassword", ErrorMessage ="Konfirmasi password tidak sesuai")]
        public string confirmPassword { get; set; } = null!;
    }
}
