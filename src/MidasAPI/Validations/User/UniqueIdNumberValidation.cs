using MidasAPI.DTOs.User;
using MidasDataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace MidasAPI.Validations.User
{
    public class UniqueIdNumberValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var dbContext = (MidasContext?)validationContext
                    .GetService(typeof(MidasContext))
                    ?? throw new NullReferenceException("Kesalahan sistem");
                var isExists = dbContext.Users.Any(user =>
                    user.IdentityNumber == value.ToString() &&
                    user.DeletedAt == null
                );
                if (isExists)
                    return new ValidationResult($"Nomor Identitas {value.ToString()} sudah ada");
            }
            return ValidationResult.Success;
        }
    }
}

