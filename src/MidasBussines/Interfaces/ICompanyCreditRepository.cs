using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{   
    List<CompanyCredit> GetDraft(int page, int pageSize, string status);
    List<CompanyCredit> GetCreditPerCustomer(int page, int pageSize, string customerId);
    int CountData();
    int CountData(string customerId);
    CompanyCredit GetById(string id);   
    void InsertDraft(CompanyCredit companyCredit);
    void UpdateDraft(CompanyCredit companyCredit);
    void ApplyCredit(CompanyCredit companyCredit);
    void Verification(CompanyCredit companyCredit);
}
