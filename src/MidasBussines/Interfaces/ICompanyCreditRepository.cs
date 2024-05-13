using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{   
    List<CompanyCredit> GetDraft(int page, int pageSize);
    int CountData();
    CompanyCredit GetById(string id);   
    void InsertDraft(CompanyCredit companyCredit);
    void UpdateDraft(CompanyCredit companyCredit);
    void ApplyCredit(CompanyCredit companyCredit);
    void CreditVerification(CompanyCredit companyCredit);
    void CreditRevision(CompanyCredit companyCredit);
    void FinalVerification(CompanyCredit companyCredit);
}
