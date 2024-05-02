using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using MidasAPI.DTOs.Authorization;
using MidasBussines;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class AuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IConfiguration _configuration;

    public AuthService(IUserRepository userRepository, IConfiguration configuration)
    {
        _userRepository = userRepository;
        _configuration = configuration;
    }


    public AuthResponseDTO CreateToken(User model){
        List<Claim> claims = new List<Claim>(){
            new Claim("nickname", model.NickName),
            new Claim("userId", model.Id),
            new Claim(ClaimTypes.Role, model.Role.Name)
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
            Token = serializedToken,
            Nickname = model.NickName,
            Role = model.Role.Name
        };
    }


    public AuthResponseDTO GetToken(AuthRequestDTO request){
        var model = _userRepository.GetByEmail(request.Email);
        
        if(model.Email == null){
            return new AuthResponseDTO();
        }

        bool passwordIsMatch = BCrypt.Net.BCrypt.Verify(request.Password, model?.Password);

        if(!passwordIsMatch){
            return new AuthResponseDTO();
        }

        var token = _userRepository.GetByEmail(request.Email);
        return CreateToken(token ?? throw new NullReferenceException(""));
    }

    
}
