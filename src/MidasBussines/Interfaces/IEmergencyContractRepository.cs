using MidasDataAccess.Models;

namespace MidasBussines.Interfaces
{
    public interface IEmergencyContactRepository
    {
        public void Insert(EmergencyContact model);
        public void Update(EmergencyContact model);
        public void DeleteByCredit(string individualCreditId);
    }
}
