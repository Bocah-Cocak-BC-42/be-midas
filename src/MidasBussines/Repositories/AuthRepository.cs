using MidasDataAccess.Models;

namespace MidasBussines;

public class AuthRepository : IAuthRepository
{   
    private readonly MidasContext _dbContext;

    public AuthRepository(MidasContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User? GetUserByEmail(string userEmail){
        var users = _dbContext.Users;
        return users.Where(user => user.Email == userEmail).First();
    }
}
