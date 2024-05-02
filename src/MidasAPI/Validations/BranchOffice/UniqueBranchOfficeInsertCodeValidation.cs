using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;
using MidasAPI.DTOs.BranchOffice;
namespace MidasAPI.Validations.BranchOffice;

public class UniqueBranchOfficeInsertCodeValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");
            var isExists = dbContext.BranchOffices.Any(office=>
                office.OfficeCode==value.ToString() &&
                office.DeletedAt == null
            );
            if(isExists) 
                return new ValidationResult($"Kantor Cabang berkode {value.ToString()} sudah ada, tolong masukan kode yang lain!");
        }
        return ValidationResult.Success;
    }
}
