using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IAuthRepository
{
    public User? GetUserByEmail(string userEmail);
}
