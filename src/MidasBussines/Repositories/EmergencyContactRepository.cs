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
    public class EmergencyContactRepository : IEmergencyContactRepository
    {
        private readonly MidasContext _context;

        public EmergencyContactRepository(MidasContext context)
        {
            _context = context;
        }

        public void Insert(EmergencyContact model)
        {
            try
            {
                _context.EmergencyContacts.Add(model);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            };
        }

        public void Update(EmergencyContact model)
        {
            try
            {
                _context.EmergencyContacts.Update(model);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            };
        }
    }
}
