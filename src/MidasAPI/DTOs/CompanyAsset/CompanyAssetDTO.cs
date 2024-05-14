using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.CompanyAsset;

public class CompanyAssetDTO
{   

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "{0} harus berupa karakter!")]
    [Display(Name = "Nama Aset")]
    public string Name { get; set; } = null!;


    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Harga Aset")]
    public decimal Value { get; set; }
}
