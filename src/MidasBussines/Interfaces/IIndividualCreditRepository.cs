using MidasDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasBussines.Interfaces
{
    public interface IIndividualCreditRepository
    {
        public List<IndividualCredit> GetByStatus(int page, int pageSize, string status);
        public List<IndividualCredit> GetByCustomer(int page, int pageSize, string userId);
        public IndividualCredit? GetById(string id);
        public void Insert(IndividualCredit model);
        public void Update(IndividualCredit model);
    }
}
