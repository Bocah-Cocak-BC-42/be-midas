using MidasDataAccess.Models;

namespace MidasDataAccess.Seeders;

public static class UserSeeder
{
    public static List<User> SeedUsers()
    {
        return new List<User>(){
            new User
            {
                Id = "41dfada5-6c53-4c7b-8c07-89037e511874",
                Email = "admin@midas.com",
                Password = "$2a$12$ZEqw5fRxjcndbH.TekcXq.Pvk03lJD.mzxN73qownotDhtSfJ.vdq",
                FullName = "Admin",
                NickName = "Admin",
                IdentityNumber = "AA00000001",
                Gender = "M",
                RoleId = "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                RegistrationDate = DateTime.Now,
                CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
                CreatedAt = DateTime.Now
            }
        };
    }
}
