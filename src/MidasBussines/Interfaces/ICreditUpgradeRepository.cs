using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICreditUpgradeRepository
{
    CreditUpgrade? Get(string id);
    List<CreditUpgrade> GetCreditUpgradesCustomer(string userId);
    List<CreditUpgrade> GetCreditUpgradeAdmin(int page, int pageSize);
    List<CreditUpgrade> GetCreditUpgradeSupervisor(int page, int pageSize);
    void Insert(CreditUpgrade creditUpgrade);
    void Update(CreditUpgrade creditUpgrade);

}
