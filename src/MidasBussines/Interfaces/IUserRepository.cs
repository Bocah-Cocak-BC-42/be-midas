using MidasDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasBussines.Interfaces
{
    public interface IUserRepository
    {
        public User GetById(string id);
        public User GetByEmail(string email);
        public List<User> GetAllCustomers(int pageNumber, int pageSize, string fullName, string identityNumber);
        public List<User> GetAllEmployee(int pageNumber, int pageSize, string fullName, string identityNumber, string role);
        public int CountAllCustomers(string fullName, string identityNumber);
        public int CountAllEmployee(string fullName, string identityNumber, string role);
        public User GetCustomerByName(string name);
        public void Insert(User model);
        public void Update(User model);
    }
}
