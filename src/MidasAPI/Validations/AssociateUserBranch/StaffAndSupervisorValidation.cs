using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;
using MidasBussines.Repositories;
using MidasBussines.Interfaces;

namespace MidasAPI.Validations.AssociateUserBranch;

public class StaffAndSupervisorValidation : ValidationAttribute
{
    private readonly IUserRepository _userRepo = null!;

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");
            var employeeInfo = _userRepo.GetById(value.ToString()?? throw new NullReferenceException("Kesalahan sistem"));
            if (employeeInfo.Role.Name=="Mantri" || employeeInfo.Role.Name=="Supervisor")
            {
                var isEmployeeeExist = dbContext.AssociateUserBranches.Any(associate=>
                    associate.UserId == value.ToString()
                ); 
                if(isEmployeeeExist) 
                    return new ValidationResult($"Mantri/Supervisor ini sudah terdaftar di kantor cabang yang lain, mohon gunakan nama yang lainnya");
            }
        }
        return ValidationResult.Success;
    }
}
