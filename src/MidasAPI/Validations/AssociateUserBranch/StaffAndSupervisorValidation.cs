using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;
using MidasBussines.Repositories;
using MidasBussines.Interfaces;
using MidasAPI.DTOs.AssociateUserBranch;

namespace MidasAPI.Validations.AssociateUserBranch;

public class StaffAndSupervisorValidation : ValidationAttribute
{

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))?? throw new NullReferenceException("Kesalahan sistem");
            UserRepository _userRepo = new UserRepository(dbContext);
            var employeeInfo = _userRepo.GetById(value.ToString()?? throw new NullReferenceException("Kesalahan sistem"));
            var branchOfficeId = ((AssociateUserBranchInsertDTO)validationContext.ObjectInstance).BranchOfficeId;
            if (employeeInfo.Role.Name=="Mantri" || employeeInfo.Role.Name=="Supervisor"){
                if (employeeInfo.Role.Name=="Supervisor"){
                    var isAnySupervisor = dbContext.AssociateUserBranches.Any(associate=>
                        associate.BranchOfficeId == branchOfficeId &&
                        associate.User.Role.Name=="Supervisor"
                    );
                    if(isAnySupervisor) 
                        return new ValidationResult($"Hanya boleh ada 1 orang Supervisor di kantor cabang ini, mohon gunakan kantor cabang yang lainnya");
                }
                var isEmployeeeExist = dbContext.AssociateUserBranches.Any(associate=>
                    associate.UserId == value.ToString()
                ); 
                if(isEmployeeeExist) 
                    return new ValidationResult($"Mantri/Supervisor ini sudah terdaftar di kantor cabang ini atau yang lain, mohon gunakan nama yang lainnya");
            } else if (employeeInfo.Role.Name=="Manager" || employeeInfo.Role.Name=="Direktur") {
                var isManagerExist = dbContext.AssociateUserBranches.Any(associate=>
                    associate.BranchOfficeId == branchOfficeId &&
                    associate.UserId == value.ToString()
                ); 
                if(isManagerExist) 
                    return new ValidationResult($"Manager/Direktur ini sudah terdaftar di kantor cabang ini, mohon gunakan kantor cabang yang lainnya"); 
            }
        }
        return ValidationResult.Success;
    }
}
