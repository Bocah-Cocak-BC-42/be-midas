using Microsoft.EntityFrameworkCore;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MidasContext _context;

        public UserRepository(MidasContext dbContext)
        {
            this._context = dbContext;
        }

        public User GetById(string id)
        {
            return _context.Users.Include("Role").Where(user => user.Id == id).FirstOrDefault() ?? new User();
        }

        public User GetByEmail(string email)
        {
            return _context.Users.Include("Role").Where(user => user.Email == email).FirstOrDefault() ?? new User();
        }

        public List<User> GetAllCustomers(int pageNumber, int pageSize, string fullName, string identityNumber)
        {
            return _context.Users.Include("Role").Where(user => user.Role.Name == "Nasabah"
            && user.FullName.Contains(fullName??"") && user.IdentityNumber.Contains(identityNumber??"")
            && user.DeletedAt == null)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<User> GetAllEmployee(int pageNumber, int pageSize, string fullName, string identityNumber, string role)
        {
            return _context.Users.Include("Role").Where(user => user.Role.Name != "Nasabah"
            && user.FullName.Contains(fullName ?? "") && user.IdentityNumber.Contains(identityNumber ?? "")
            && user.Role.Name.Contains(role ?? "") && user.DeletedAt == null)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public int CountAllCustomers(string fullName, string identityNumber)
        {
            return _context.Users.Include("Role").Where(user => user.Role.Name == "Nasabah"
            && user.FullName.Contains(fullName?? "") && user.IdentityNumber.Contains(identityNumber ?? "")
            && user.DeletedAt == null)
            .Count();
        }

        public int CountAllEmployee(string fullName, string identityNumber, string role)
        {
            return _context.Users.Include("Role").Where(user => user.Role.Name != "Nasabah"
            && user.FullName.Contains(fullName ?? "") && user.IdentityNumber.Contains(identityNumber ?? "")
            && user.Role.Name.Contains(role ?? "") && user.DeletedAt == null)
            .Count();
        }

        public User GetCustomerByName(string name)
        {
            return _context.Users.Include("Role").Where(user => user.Role.Name == "Nasabah" 
            && user.FullName.Contains(name??"") && user.DeletedAt == null)
            .First();
        }

        public void Insert(User model)
        {
            try
            {
                _context.Users.Add(model);
                _context.SaveChanges();
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
                _context.Users.Update(model);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            };
        }
    }
}
