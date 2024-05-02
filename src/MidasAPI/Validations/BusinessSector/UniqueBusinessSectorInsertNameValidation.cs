using System.ComponentModel.DataAnnotations;
using MidasAPI.DTOs.BusinessSector;
using MidasDataAccess.Models;

namespace MidasAPI.Validations.BusinessSector;

public class UniqueBusinessSectorInsertNameValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");
            var isExists = dbContext.BusinessSectors.Any(sector=>
                sector.Name==value.ToString() &&
                sector.DeletedAt == null
            );
            if(isExists) 
                return new ValidationResult($"Sektor usaha bernama {value.ToString()} sudah ada, tolong masukan nama yang lain!");
        }
        return ValidationResult.Success;
    }
}
