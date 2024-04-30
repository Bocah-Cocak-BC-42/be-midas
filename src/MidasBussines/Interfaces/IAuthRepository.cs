using MidasDataAccess.Models;

namespace MidasBussines;

public interface IAuthRepository
{
    public User? GetUserByEmail(string userEmail);
}
