using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{
    CompanyCredit GetById(string id);
    void Insert(CompanyCredit companyCredit);
    void UpdateDraft(CompanyCredit companyCredit);
    void ApplyCredit(CompanyCredit companyCredit);
    void CreditRejected(CompanyCredit companyCredit);
}
