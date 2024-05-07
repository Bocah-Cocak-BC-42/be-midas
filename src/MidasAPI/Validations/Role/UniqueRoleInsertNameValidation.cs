using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;

namespace MidasAPI.Validations.Role;

public class UniqueRoleInsertNameValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext){

        if(value != null){
            var dbContext = (MidasContext?) validationContext.GetService(typeof(MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");

            var isNameExists = dbContext.Roles.Any(role => role.Name == value.ToString() && role.DeletedAt == null);

            if(isNameExists){
                return new ValidationResult($"Jabatan {value.ToString()} sudah terdaftar, tolong masukkan nama yang lain!");
            }
        }

        return ValidationResult.Success;
    }
}
