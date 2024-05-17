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
        public List<IndividualCredit> GetByStatus(int page, int pageSize, string status, string userId);
        public IndividualCredit? GetById(string id);
        public int CountByStatus(string userId, string status);
        public void Insert(IndividualCredit model);
        public void Update(IndividualCredit model);
    }
}
