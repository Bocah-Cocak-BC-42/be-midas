using MidasAPI.DTOs.User;

namespace MidasAPI;

public class BranchOfficeResponseDetailDTO
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string City { get; set; } = null!;
    public string SubDistrict { get; set; } = null!;
    public string Village { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public List<UserDetailDTO> Employees { get; set; } = new List<UserDetailDTO>();
}
