using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{   
    List<CompanyCredit> GetByStatus(int page, int pageSize, string status);
    List<CompanyCredit> GetCreditPerCustomer(int page, int pageSize, string status, string userId);
    int CountData();
    int CountData(string userId);
    CompanyCredit GetById(string id);   
    void InsertDraft(CompanyCredit companyCredit);
    void UpdateDraft(CompanyCredit companyCredit);
    void ApplyCredit(CompanyCredit companyCredit);
    void CreditVerification(CompanyCredit companyCredit);
    void CreditRevision(CompanyCredit companyCredit);
    void FinalVerification(CompanyCredit companyCredit);
}
