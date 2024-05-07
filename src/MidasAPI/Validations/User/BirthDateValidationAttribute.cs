using System.ComponentModel.DataAnnotations;

namespace MidasAPI.Validations.User
{
    public class BirthDateValidation: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                DateOnly val = (DateOnly)value;
                TimeSpan timeSpan = DateTime.Now - new DateTime(val.Year, val.Month, val.Day);
                int currentAge = Convert.ToInt32(Math.Floor(Convert.ToDouble(timeSpan.TotalDays - 1)  / 365.25));

                if (val > DateOnly.FromDateTime(DateTime.Now))
                    return new ValidationResult("Tanggal Lahir tidak bisa melebihi tanggal hari ini");

                else if (currentAge < 17)
                    return new ValidationResult("Umur masih dibawah 17 tahun");
            }
            return ValidationResult.Success;
        }
    }
}
