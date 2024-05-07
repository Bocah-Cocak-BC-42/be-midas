using System.ComponentModel.DataAnnotations;
using MidasAPI.DTOs.Role;
using MidasDataAccess.Models;

namespace MidasAPI.Validations.Role;

public class UniqueRoleUpdateNameValidation : ValidationAttribute
{
     protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext.GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");

            var id = ((UpdateRoleDTO)validationContext.ObjectInstance).Id;

            var isNameExists = dbContext.Roles.Any(role=>
                role.Name == value.ToString() &&
                role.DeletedAt == null &&
                role.Id != id
            );

            if(isNameExists) 
                return new ValidationResult($"Jabatan {value.ToString()} sudah terdaftar, tolong masukkan nama yang lain!");
        }
        return ValidationResult.Success;
    }
}
