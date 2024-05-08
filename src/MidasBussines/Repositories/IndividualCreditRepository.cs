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
    public class IndividualCreditRepository : IIndividualCreditRepository
    {
        private readonly MidasContext _context;

        public IndividualCreditRepository(MidasContext context)
        {
            _context = context;
        }

        public List<IndividualCredit> GetByStatus(int page, int pageSize, string status)
        {
            return _context.IndividualCredits.Include("User").Where(indiv => indiv.Status == status)
                .Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public void Insert(IndividualCredit model)
        {
            _context.IndividualCredits.Add(model);
            _context.SaveChanges();
        }

        public void Update(IndividualCredit model)
        {
            _context.IndividualCredits.Update(model);
            _context.SaveChanges();
        }
    }
}
