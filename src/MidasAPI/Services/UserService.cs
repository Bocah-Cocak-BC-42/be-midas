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

    public List<CustomerResponseDTO> GetAllCustomer(int pageNumber, int pageSize, string fullName, string identityNumber)
    {
        return _userRepository.GetAllCustomers(pageNumber, pageSize, fullName, identityNumber).Select(x => new CustomerResponseDTO
            {
                Id = x.Id,
                FullName = x.FullName,
                NickName = x.NickName,
                IdentityNumber = x.IdentityNumber,
                CreditScore = x.CreditScore
            }).ToList();
    }
}
