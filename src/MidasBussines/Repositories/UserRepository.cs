using Microsoft.EntityFrameworkCore;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return dbContext.Users.Where(user => user.RoleId == id).First();
        }

        public List<User> GetAllCustomers(int pageNumber, int pageSize, string fullName, string identityNumber)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name == "Nasabah" 
            && user.FullName.Contains(fullName??"") && user.IdentityNumber.Contains(identityNumber??""))
                .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public int CountAllCustomers(string fullName, string identityNumber)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name == "Nasabah"
            && user.FullName.Contains(fullName?? "") && user.IdentityNumber.Contains(identityNumber ?? ""))
                .Count();
        }
        public User GetCustomerByName(string name)
        {
            return dbContext.Users.Include("Role").Where(user => user.Role.Name == "Nasabah" && user.FullName.Contains(name??""))
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
