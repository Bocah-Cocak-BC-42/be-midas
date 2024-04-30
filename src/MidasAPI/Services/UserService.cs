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
            RegistrationDate = DateTime.Now
        };

        model.CreatedBy = model.Id;

        _userRepository.Insert(model);
    }

    public void AddEmployee(EmployeeRegisterDTO employeeRegisterDTO)
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
            RegistrationDate = DateTime.Now
        };

        model.CreatedBy = model.Id;

        _userRepository.Insert(model);
    }
}
