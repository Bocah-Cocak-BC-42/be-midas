using MidasAPI.DTOs.City;
using MidasAPI.DTOs.Province;
using MidasAPI.DTOs.Village;

namespace MidasAPI.DTOs.BranchOffice
;

public class BranchOfficeGetUpdateDTO
{
    public string Id { get; set; } = null!;
    public string OfficeName { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string City { get; set; } = null!;
    public string SubDistrict { get; set; } = null!;
    public string Village { get; set; } = null!;
    public string VillageId { get; set; } = null!;
    public List<ProvinceResponseDTO> Provinces { get; set; } = new List<ProvinceResponseDTO>();
    public List<CityResponseDTO> Cities { get; set; } = new List<CityResponseDTO>();
    public List<VillageResponseDTO> Villages { get; set; } = new List<VillageResponseDTO>();
}
