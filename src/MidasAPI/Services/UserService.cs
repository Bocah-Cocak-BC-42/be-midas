using Azure.Core;
using BCrypt.Net;
using MidasAPI.DTOs.User;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<UserResponseDTO> GetAllCustomer(int pageNumber, int pageSize, string fullName, string identityNumber)
    {
        return _userRepository.GetAllCustomers(pageNumber, pageSize, fullName, identityNumber).Select(x => new UserResponseDTO
            {
                Id = x.Id,
                Role = x.Role.Name,
                FullName = x.FullName,
                NickName = x.NickName,
                IdentityNumber = x.IdentityNumber,
                CreditScore = x.CreditScore
            }).ToList();
    }

    public List<UserResponseDTO> GetAllEmployee(int pageNumber, int pageSize, string fullName, string identityNumber, string role)
    {
        return _userRepository.GetAllEmployee(pageNumber, pageSize, fullName, identityNumber, role).Select(x => new UserResponseDTO
        {
            Id = x.Id,
            Role = x.Role.Name,
            FullName = x.FullName,
            NickName = x.NickName,
            IdentityNumber = x.IdentityNumber,
            CreditScore = x.CreditScore
        }).ToList();
    }

    public int CountAllCustomers(string fullName, string identityNumber)
    {
        return _userRepository.CountAllCustomers(fullName, identityNumber);
    }

    public int CountAllEmployee(string fullName, string identityNumber, string role)
    {
        return _userRepository.CountAllEmployee(fullName, identityNumber, role);
    }

    public UserDetailDTO GetById(string id)
    {
        var model = _userRepository.GetById(id);
        return new UserDetailDTO
        {
            Id = model.Id,
            Email = model.Email,
            FullName = model.FullName,
            NickName = model.NickName,
            Gender = model.Gender,
            BirthPlace = model.BirthPlace,
            BirthDate = model.BirthDate,
            PhoneNumber = model.PhoneNumber,
            RoleId = model.RoleId,
            IdentityNumber = model.IdentityNumber,
            CreditScore = model.CreditScore,
            PersonalCreditLimit = model.PersonalCreditLimit,
            CompanyCreditLimit = model.CompanyCreditLimit,
            RegistrationDate = model.RegistrationDate
        };
    }

    public void AddCustomer(CustomerRegisterDTO customerRegisterDTO)
    {
        var model = new User()
        {
            Id = Guid.NewGuid().ToString(),
            RoleId = "445e48a4-f3f6-4660-96d7-82505bc740d3",
            Email = customerRegisterDTO.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(customerRegisterDTO.Password),
            FullName = customerRegisterDTO.FullName,
            NickName = customerRegisterDTO.NickName,
            IdentityNumber = customerRegisterDTO.IdentityNumber,
            Gender = customerRegisterDTO.Gender,
            BirthPlace = customerRegisterDTO.BirthPlace,
            BirthDate = customerRegisterDTO.BirthDate,
            PhoneNumber = customerRegisterDTO.PhoneNumber,
            CreditScore = 100,
            PersonalCreditLimit = 100_000_000,
            CompanyCreditLimit = 1_000_000_000,
            RegistrationDate = DateTime.Now,
            CreatedAt = DateTime.Now
        };

        model.CreatedBy = model.Id;

        _userRepository.Insert(model);
    }

    public void AddEmployee(EmployeeRegisterDTO employeeRegisterDTO, string adminId)
    {
        var model = new User()
        {
            Id = Guid.NewGuid().ToString(),
            RoleId = employeeRegisterDTO.RoleId,
            Email = employeeRegisterDTO.Email,
            Password = BCrypt.Net.BCrypt.HashPassword("karyawan123"),
            FullName = employeeRegisterDTO.FullName,
            NickName = employeeRegisterDTO.NickName,
            IdentityNumber = employeeRegisterDTO.IdentityNumber,
            Gender = employeeRegisterDTO.Gender,
            RegistrationDate = DateTime.Now,
            CreatedAt = DateTime.Now,
            CreatedBy = adminId
        };

        _userRepository.Insert(model);
    }

    public void UpdateCustomer(CustomerUpdateDTO customerUpdateDTO, string userId)
    {
        var model = _userRepository.GetById(customerUpdateDTO.Id?? "User tidak ada");
        model.Email = customerUpdateDTO.Email;
        model.FullName = customerUpdateDTO.FullName;
        model.NickName = customerUpdateDTO.NickName;
        model.IdentityNumber = customerUpdateDTO.IdentityNumber;
        model.Gender = customerUpdateDTO.Gender;
        model.BirthPlace = customerUpdateDTO.BirthPlace;
        model.BirthDate = customerUpdateDTO.BirthDate;
        model.PhoneNumber = customerUpdateDTO.PhoneNumber;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = userId;

        _userRepository.Update(model);
    }

    public void UpdateEmployee(EmployeeUpdateDTO employeeUpdateDTO, string adminId)
    {
        var model = _userRepository.GetById(employeeUpdateDTO.Id ?? "User tidak ada");
        model.Email = employeeUpdateDTO.Email;
        model.FullName = employeeUpdateDTO.FullName;
        model.NickName = employeeUpdateDTO.NickName;
        model.IdentityNumber = employeeUpdateDTO.IdentityNumber;
        model.Gender = employeeUpdateDTO.Gender;
        model.RoleId = employeeUpdateDTO.RoleId;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = adminId;

        _userRepository.Update(model);
    }

    public void ResetPassword(string userId)
    {
        var model = _userRepository.GetById(userId);

        if(model.Role.Name == "Nasabah")
            model.Password = BCrypt.Net.BCrypt.HashPassword("nasabah123");
        else
            model.Password = BCrypt.Net.BCrypt.HashPassword("karyawan123");

        _userRepository.Update(model);
    }

    public bool ChangePassword(ChangePasswordDTO changePasswordDTO, string userId)
    {
        var model = _userRepository.GetById(userId);
        bool isChanged = BCrypt.Net.BCrypt.Verify(changePasswordDTO.oldPassword, model.Password);
        if (!isChanged) 
            return false;

        model.Password = BCrypt.Net.BCrypt.HashPassword(changePasswordDTO.newPassword);
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = userId;

        _userRepository.Update(model);
        return true;
    }
}
