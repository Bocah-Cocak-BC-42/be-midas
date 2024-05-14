using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs.IndividualCredit;

public class IndividualCreditInsertDTO
{
    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Nomor Kartu Keluarga")]
    public string FamilyCardNumber { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Length(20, 200, ErrorMessage = "{0} minimal 20 karakter dan maksimal 200 karakter")]
    [Display(Name = "Alamat Tempat Usaha")]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Id Desa/Kelurahan")]
    public string VillageId { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} hanya boleh berupa huruf")]
    [Display(Name = "Nama Usaha")]
    public string BusinessName { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Id Sektor Usaha")]
    public string BusinessSectorId { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Length(20, 200, ErrorMessage = "{0} minimal 20 karakter dan maksimal 200 karakter")]
    [Display(Name = "Alamat Tempat Usaha")]
    public string BusinessAddress { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "No. Telepon Tempat Usaha")]
    public string BusinessPhoneNumber { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int32.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Lama Berdirinya Usaha (Tahun)")]
    public string BusinessPeriod { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "{0} hanya boleh berupa huruf")]
    [Display(Name = "Status Tempat Usaha")]
    public string BusinessPlaceStatus { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int32.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Jumlah Karyawan")]
    public string TotalEmployee { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Id Desa/Kelurahan Tempat Usaha")]
    public string BusinessVillage { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "Id Kantor Cabang")]
    public string BranchOfficeId { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int64.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Jumlah Kredit")]
    public decimal ApplicationAmount { get; set; }

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Range(1, Int32.MaxValue, ErrorMessage = "{0} harus berupa angka")]
    [Display(Name = "Jangka Waktu Kredit (Tahun)")]
    public string ApplicationPeriod { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "File Surat Domisili")]
    public string DomicileFile { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "File KTP")]
    public string IdentityCardFile { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "File Selfie KTP")]
    public string IdentityCardSelfieFile { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "File Kartu Keluarga")]
    public string FamilyCardFile { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "File Surat Keterangan Usaha")]
    public string BusinessCertificateFile { get; set; } = null!;

    [Required(ErrorMessage = "{0} tidak boleh kosong")]
    [Display(Name = "List Kontak Darurat")]
    public List<EmergencyContactDTO> EmergencyContacts { get; set; } = new List<EmergencyContactDTO>();
}
