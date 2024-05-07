using MidasAPI.DTOs.User;
using MidasDataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace MidasAPI.Validations.User
{
    public class UniqueIdNumberUpdateCustomerValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var dbContext = (MidasContext?)validationContext
                    .GetService(typeof(MidasContext))
                    ?? throw new NullReferenceException("Kesalahan sistem");

                var id = ((CustomerUpdateDTO)validationContext.ObjectInstance).Id;

                bool isExists = dbContext.Users.Any(user =>
                    user.IdentityNumber == value.ToString() &&
                    user.DeletedAt == null &&
                    user.Id != id
                );
                if (isExists)
                    return new ValidationResult($"NIK {value.ToString()} sudah ada, tolong masukan email yang lain!");
            }
            return ValidationResult.Success;
        }
    }
}
