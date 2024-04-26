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
        public List<User> GetAllCustomers(int pageNumber, int pageSize);
        public int CountAllCustomers();
        public User GetCustomerByName(string name);
        public void Insert(User model);
        public void Update(User model);
        public void SoftDelete(User model);
    }
}
