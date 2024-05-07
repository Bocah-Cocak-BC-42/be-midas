using MidasAPI.DTOs.User;
using MidasDataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace MidasAPI.Validations.User
{
    public class UniqueEmailUpdateEmployeeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var dbContext = (MidasContext?)validationContext
                    .GetService(typeof(MidasContext))
                    ?? throw new NullReferenceException("Kesalahan sistem");

                var id = ((EmployeeUpdateDTO)validationContext.ObjectInstance).Id;

                bool isExists = dbContext.Users.Any(user =>
                    user.Email == value.ToString() &&
                    user.DeletedAt == null &&
                    user.Id != id
                );
                if (isExists)
                    return new ValidationResult($"Email {value.ToString()} sudah ada, tolong masukan email yang lain!");
            }
            return ValidationResult.Success;
        }
    }
}
