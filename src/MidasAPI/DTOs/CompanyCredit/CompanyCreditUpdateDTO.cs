using System.ComponentModel.DataAnnotations;
using MidasAPI.DTOs.BusinessOwnerDetail;
using MidasAPI.DTOs.CompanyAsset;
using MidasAPI.Validations.CompanyCredit;

namespace MidasAPI.DTOs.CompanyCredit;

public class CompanyCreditUpdateDTO
{
    public string Id { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage ="{0} harus berupa angka")]
    [Display(Name = "NPWP Badan Usaha")]
    public string Npwp { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "{0} harus berupa karakter!")]
    [Display(Name = "Nama Perusahaan")]
    public string CompanyName { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Jenis Perusahaan")]
    public string CompanyType { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "{0} harus berupa karakter!")]
    [Display(Name = "Tempat pendirian perusahaan")]
    public string PlaceOfEstasblishment { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Nomor Akta Pendirian perusahaan")]
    public string EstablishRegistrationNumber { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [EstablishRegistrationDateValidation]
    [Display(Name = "Tanggal Akta Pendirian perusahaan")]
    public DateOnly EstablishRegistrationDate { get; set; }

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Nomor Induk Berusaha")]
    [Range(1, Int64.MaxValue, ErrorMessage ="{0} harus berupa angka")]
    public string CompanyRegistrationNumber { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [EmailAddress(ErrorMessage ="Format Email salah")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage ="{0} harus berupa angka")]
    [Display(Name = "Nomor Telepon")]
    public string PhoneNumber { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Alamat perusahaan")]
    [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "{0} harus berupa karakter!")]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Kelurahan/Desa")]
    public string VillageId { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Kantor cabang")]
    public string BranchOfficeId { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Nominal pengajuan")]
    [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "{0} harus berupa angka")]
    public decimal ApplicationAmount { get; set; }

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Jangka waktu pengajuan")]
    [Range(1, 10, ErrorMessage = "{0} harus antara 1 sampai 10")]
    public int ApplicationPeriod { get; set; }
    public string EstablishRegistrationNumberFile { get; set; } = null!;
    public string CompanyRegistrationNumberFile { get; set; } = null!;
    public string Npwpfile { get; set; } = null!;
    public string IdentityNumberFile { get; set; } = null!;
    public string BoardOfManagementFile { get; set; } = null!;
    public string FinancialStatementFile { get; set; } = null!;
    public List<BusinessOwnerDetailDTO> BusinessOwnerDetails { get; set; } = null!;
    public List<CompanyAssetDTO> CompanyAssets { get; set; } = null!;
}
