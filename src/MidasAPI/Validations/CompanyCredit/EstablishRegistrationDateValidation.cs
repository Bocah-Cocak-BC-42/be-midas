using System.ComponentModel.DataAnnotations;

namespace MidasAPI.Validations.CompanyCredit;

public class EstablishRegistrationDateValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext){

        if(value != null){
            DateOnly val = (DateOnly)value;

            if(val > DateOnly.FromDateTime(DateTime.Now)){
                return new ValidationResult("Tanggal Akta Pendirian tidak bisa melebihi tanggal hari ini");
            }
        }

        return ValidationResult.Success;
    }

}
