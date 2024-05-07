using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;
using MidasBussines.Repositories;
using MidasBussines.Interfaces;
using MidasAPI.DTOs.AssociateUserBranch;


namespace MidasAPI;

public class StaffAndSupervisorUpdateValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");
            UserRepository _userRepo = new UserRepository(dbContext);
            var employeeInfo = _userRepo.GetById(value.ToString()?? throw new NullReferenceException("Kesalahan sistem"));
            var branchOfficeId = ((AssociateUserBranchUpdateDTO)validationContext.ObjectInstance).BranchOfficeId;
            if (employeeInfo.Role.Name=="Mantri" || employeeInfo.Role.Name=="Supervisor"){
                var isEmployeeeExist = dbContext.AssociateUserBranches.Any(associate=>
                    associate.UserId == value.ToString()&&
                    associate.BranchOfficeId!=branchOfficeId
                ); 
                if(isEmployeeeExist) 
                    return new ValidationResult($"Mantri/Supervisor ini sudah terdaftar di kantor cabang yang lain, mohon gunakan nama yang lainnya");
            } 
        }
        return ValidationResult.Success;
    }
}
