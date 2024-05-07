using Microsoft.EntityFrameworkCore;
using MidasDataAccess.Models;

namespace MidasDataAccess.Seeders;

public static class RoleSeeder
{
    public static List<Role> SeedRoles()
    {
        return new List<Role>(){
            new Role
            {
                Id = "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                Name = "Admin",
                CreatedAt = DateTime.Now
            },
            new Role
            {
                Id = "445e48a4-f3f6-4660-96d7-82505bc740d3",
                Name = "Nasabah",
                CreatedAt = DateTime.Now
            },
            new Role
            {
                Id = "0ca5493b-903d-4863-8194-f1a2925f2088",
                Name = "Supervisor",
                CreatedAt = DateTime.Now
            },
            new Role
            {
                Id = "15bbe07e-c6e8-4a82-bedf-4a4303594292",
                Name = "Mantri",
                CreatedAt = DateTime.Now
            },
            new Role
            {
                Id = "1f7e704a-d720-49bb-9129-a317cb79756a",
                Name = "Direktur",
                CreatedAt = DateTime.Now,
            },
            new Role
            {
                Id = "fb0ea19a-7d05-4b0a-9532-59138d1a7bad",
                Name = "Manager",
                CreatedAt = DateTime.Now,
            }
        };
    }
}
