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

    public List<UserResponseDTO> GetAllCustomer(int pageNumber, int pageSize)
    {
        return _userRepository.GetAllCustomers(pageNumber, pageSize).Select(x => new UserResponseDTO
            {
                Id = x.Id,
                Email = x.Email,
                FullName = x.FullName,
                NickName = x.NickName,
                IdentityNumber = x.IdentityNumber,
                Gender = x.Gender,
                BirthPlace = x.BirthPlace,
                BirthDate = x.BirthDate,
                PhoneNumber = x.PhoneNumber,
                CreditScore = x.CreditScore,
                PersonalCreditLimit = x.PersonalCreditLimit,
                CompanyCreditLimit = x.CompanyCreditLimit,
                RegistrationDate = x.RegistrationDate,
                RoleId = x.RoleId,
                CreatedBy = x.CreatedBy,
                CreatedAt = x.CreatedAt,
                UpdatedBy = x.UpdatedBy,
                UpdatedAt = x.UpdatedAt,
                DeletedBy = x.DeletedBy,
                DeletedAt = x.DeletedAt,
            }).ToList();
    }
}
