using MidasDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasBussines.Interfaces
{
    public interface IEmergencyContractRepository
    {
        public void Insert(EmergencyContact model);
        public void Update(EmergencyContact model);
    }
}
