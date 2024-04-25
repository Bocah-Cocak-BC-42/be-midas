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
            }
        };
    }
}
