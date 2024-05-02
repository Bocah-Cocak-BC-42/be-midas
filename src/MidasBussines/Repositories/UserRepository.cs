using Microsoft.EntityFrameworkCore;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MidasContext dbContext;

        public UserRepository(MidasContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User GetById(string id)
        {
            return dbContext.Users.Include("Role").Where(user => user.Id == id).First();
        }

        public User GetByEmail(string email)
        {
            return dbContext.Users.Include("Role").Where(user => user.Email == email).First();
        }

        public List<User> GetAllCustomers(int pageNumber, int pageSize, string fullName, string identityNumber)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name == "Nasabah" 
            && user.FullName.Contains(fullName??"") && user.IdentityNumber.Contains(identityNumber??"")
            && user.DeletedAt == null)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<User> GetAllEmployee(int pageNumber, int pageSize, string fullName, string identityNumber, string role)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name != "Nasabah"
            && user.FullName.Contains(fullName ?? "") && user.IdentityNumber.Contains(identityNumber ?? "")
            && user.Role.Name.Contains(role ?? "") && user.DeletedAt == null)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public int CountAllCustomers(string fullName, string identityNumber)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name == "Nasabah"
            && user.FullName.Contains(fullName?? "") && user.IdentityNumber.Contains(identityNumber ?? "")
            && user.DeletedAt == null)
            .Count();
        }

        public int CountAllEmployee(string fullName, string identityNumber, string role)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name != "Nasabah"
            && user.FullName.Contains(fullName ?? "") && user.IdentityNumber.Contains(identityNumber ?? "")
            && user.Role.Name.Contains(role ?? "") && user.DeletedAt == null)
            .Count();
        }

        public User GetCustomerByName(string name)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name == "Nasabah" 
            && user.FullName.Contains(name??"") && user.DeletedAt == null)
            .First();
        }

        public void Insert(User model)
        {
            try
            {
                dbContext.Users.Add(model);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(User model)
        {
            try
            {
                dbContext.Users.Update(model);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            };
        }

        public void SoftDelete(User model)
        {
            try
            {
                dbContext.Users.Update(model);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
