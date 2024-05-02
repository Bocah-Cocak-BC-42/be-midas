namespace MidasAPI.DTOs.Authorization;

public class AuthResponseDTO
{
    public string? Token { get; set; }
    public string Nickname { get; set; } = null!;
    public string Role { get; set; } = null!;
}
