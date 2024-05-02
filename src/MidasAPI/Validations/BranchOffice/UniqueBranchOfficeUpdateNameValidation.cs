﻿using System.ComponentModel.DataAnnotations;
using MidasDataAccess.Models;
using MidasAPI.DTOs.BranchOffice;
namespace MidasAPI;

public class UniqueBranchOfficeUpdateNameValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var dbContext = (MidasContext?) validationContext
                .GetService(typeof (MidasContext))
                ?? throw new NullReferenceException("Kesalahan sistem");
            var id = ((BranchOfficeUpdateDTO)validationContext.ObjectInstance).Id;
            var isExists = dbContext.BranchOffices.Any(office=>
                office.OfficeName==value.ToString() &&
                office.DeletedAt == null &&
                office.Id != id
            );
            if(isExists) 
                return new ValidationResult($"Kantor Cabang bernama {value.ToString()} sudah ada, tolong masukan nama yang lain!");
        }
        return ValidationResult.Success;
    }
}
