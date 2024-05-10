namespace MidasAPI.DTOs;

public static class ApprovalStatusConfig
{
	public static readonly string DRAFT = "Draft";
	public static readonly string WAITING_VERIFICATION_PERSONAL_DATA = "Menunggu Verifikasi Data Diri";
	public static readonly string REJECTED_PERSONAL_DATA = "Data Diri Ditolak";
	public static readonly string WAITING_VERIFICATION_FILES = "Menunggu Verifikasi Kelengkapan Berkas";
	public static readonly string REJECTED_FILES = "Kelengkapan Berkas Ditolak";
	public static readonly string WAITING_VERIFICATION_CREDIT_SCORE = "Menunggu Verifikasi Skor Kredit";
	public static readonly string REJECTED_CREDIT_SCORE = "Skor Kredit Ditolak";
	public static readonly string WAITING_VERIFICATION_MANAGER = "Menunggu Verifikasi Manager";
	public static readonly string REJECTED = "Kredit Ditolak";
	public static readonly string APPROVED = "Kredit Disetujui";
}
