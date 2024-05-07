using MidasDataAccess.Models;

namespace MidasDataAccess.Seeders;

public static class BusinessSectorSeeder
{
  public static List<BusinessSector> SeedBusinessSectors() =>
    new List<BusinessSector>()
    {
        new BusinessSector{
            Id = "1c7a0718-23d2-4f40-b0b0-9660b71124c9",
            Name = "Crypto",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        },
        new BusinessSector{
            Id = "641bf0b4-73cd-4e79-b8cf-6317c55d88f3",
            Name = "Jasa",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        },
        new BusinessSector{
            Id = "b7ef6638-3077-4d8a-815f-6885edfe14a2",
            Name = "Permainan",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        },
        new BusinessSector{
            Id = "ba4289cb-c761-470f-a1b1-03c4e391ca64",
            Name = "Kuliner",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        },
        new BusinessSector{
            Id = "c40544f0-a4d0-4cb4-9d83-8ce395496ea3",
            Name = "Keuangan",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        },
        new BusinessSector{
            Id = "e4e433de-f9bc-4c29-92a8-1e01240cbf12",
            Name = "Mebel",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        },
        new BusinessSector{
            Id = "e64ba268-3bba-4df1-aabd-3a3af2a2d05c",
            Name = "Logistik",
            CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
            CreatedAt = DateTime.Now
        }
    };
}
