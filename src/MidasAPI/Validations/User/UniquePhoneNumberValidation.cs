using MidasAPI.DTOs.User;
using MidasDataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace MidasAPI.Validations.User
{
    public class UniquePhoneNumberValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var dbContext = (MidasContext?)validationContext
                    .GetService(typeof(MidasContext))
                    ?? throw new NullReferenceException("Kesalahan sistem");
                var isExists = dbContext.Users.Any(user =>
                    user.PhoneNumber == value.ToString() &&
                    user.DeletedAt == null
                );
                if (isExists)
                    return new ValidationResult($"Nomor {value.ToString()} sudah ada, tolong masukan nomor yang lain!");
            }
            return ValidationResult.Success;
        }
    }
}
