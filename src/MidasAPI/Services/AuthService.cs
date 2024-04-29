using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

public class AuthService
{
    private readonly IAuthRepository _authRepository;
    private readonly IConfiguration _configuration;

    public AuthService(IAuthRepository authRepository, IConfiguration configuration)
    {
        _authRepository = authRepository;
        _configuration = configuration;
    }


    public AuthResponseDTO CreateToken(User model){
        List<Claim> claims = new List<Claim>(){
            new Claim(ClaimTypes.NameIdentifier, model.Email),
            new Claim(ClaimTypes.Role, model.RoleId)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value ?? throw new NullReferenceException(""))
        );

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials
        );

        var serializedToken = new JwtSecurityTokenHandler().WriteToken(token);

        return new AuthResponseDTO(){
            Token = serializedToken
        };
    }


    public AuthResponseDTO GetToken(AuthRequestDTO request){
        var model = _authRepository.GetUserByEmail(request.Email);
        bool passwordIsMatch = BCrypt.Net.BCrypt.Verify(request.Password, model?.Password);

        if(passwordIsMatch){
            return CreateToken(model ?? throw new NullReferenceException(""));
        }

        throw new EmailPasswordException("Email or Password is incorrect!");
    }

}
