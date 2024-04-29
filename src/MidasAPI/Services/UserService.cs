using MidasAPI.DTOs.User;
using MidasBussines.Interfaces;

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
}
