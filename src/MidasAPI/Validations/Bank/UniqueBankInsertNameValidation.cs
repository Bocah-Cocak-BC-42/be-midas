using System.ComponentModel.DataAnnotations;
using MidasAPI.DTOs.Bank;
using MidasDataAccess.Models;

namespace MidasAPI.Validations.Bank;

public class UniqueBankInsertNameValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");
            var isExists = dbContext.Banks.Any(bank=>
                bank.Name==value.ToString()&&
                bank.DeletedAt == null
            );
            if(isExists) 
                return new ValidationResult($"Bank bernama {value.ToString()} sudah ada, tolong masukan nama yang lain!");
        }
        return ValidationResult.Success;
    }
}
