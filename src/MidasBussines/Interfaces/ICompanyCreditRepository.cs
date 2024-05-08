using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{
    void Insert(CompanyCredit companyCredit);
}
