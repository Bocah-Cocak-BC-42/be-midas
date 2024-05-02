﻿using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.User
{
    public class EmployeeRegisterDTO
    {
        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Display(Name = "ID Jabatan")]
        public string RoleId { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} tidak boleh terdapat angka")]
        [Display(Name = "Nama Lengkap")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} tidak boleh terdapat angka")]
        [Display(Name = "Nama Panggilan")]
        public string NickName { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Range(1, Int64.MaxValue, ErrorMessage = "{0} harus berupa angka")]
        [Display(Name = "NIP")]
        public string IdentityNumber { get; set; } = null!;

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [RegularExpression("^[MFmf]*$", ErrorMessage = "Input {0} hanya boleh M/F")]
        [Length(1, 1, ErrorMessage = "Input {0} hanya boleh M/F")]
        [Display(Name = "Jenis Kelamin")]
        public string Gender { get; set; } = null!;
    }
}
