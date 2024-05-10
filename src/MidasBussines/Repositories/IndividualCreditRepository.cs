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

        public IndividualCredit? GetById(string id)
        {
            return _context.IndividualCredits.Include("User").Include("EmergencyContacts")
                .Where(indiv => indiv.Id == id && indiv.DeletedAt == null).FirstOrDefault();
        }

        public List<IndividualCredit> GetByStatus(int page, int pageSize, string status)
        {
            return _context.IndividualCredits.Include("User")
                .Where(indiv => indiv.Status == status && indiv.DeletedAt == null)
                .Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public void Insert(IndividualCredit model)
        {
            try
            {
                _context.IndividualCredits.Add(model);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Update(IndividualCredit model)
        {
            try
            {
                _context.IndividualCredits.Update(model);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
