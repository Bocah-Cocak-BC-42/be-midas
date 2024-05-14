namespace MidasAPI.DTOs.BusinessOwnerDetail;

public class BusinessOwnerDetailUpdateDTO
{   
    public string Id { get; set; } = null!;
    public string IdentityNumber { get; set; } = null!;
    public string EmployeeIdentityNumber { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public string Position { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string CompanyId { get; set; } = null!;
}
