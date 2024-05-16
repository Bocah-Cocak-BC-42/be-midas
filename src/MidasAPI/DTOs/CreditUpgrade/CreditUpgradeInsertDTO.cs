using System.ComponentModel.DataAnnotations;

namespace MidasAPI.DTOs;

public class CreditUpgradeInsertDTO
{
    [Required(ErrorMessage = "Pendapatan perbulan tidak boleh kosong")]
    public decimal MonthlyIncome { get; set; }
    [Required(ErrorMessage = "Pendapatan pertahun tidak boleh kosong")]
    public decimal AnnualBusinessGross { get; set; }
    [Required(ErrorMessage = "Total Laba tidak boleh kosong")]
    public decimal ProfitBusinessGross { get; set; }
    [Required(ErrorMessage = "Masukkan file laporan keuangan tidak boleh kosong")]
    public string FinancialStatementFileId { get; set; } = null!;
    public string Notes { get; set; } = null!;
}
