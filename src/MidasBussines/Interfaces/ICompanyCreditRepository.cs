using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{   
    List<CompanyCredit> GetByStatus(int page, int pageSize, string status, string userId);
    int CountData();
    int CountData(string userId);
    CompanyCredit GetById(string id);   
    void Insert(CompanyCredit companyCredit);
    void Update(CompanyCredit companyCredit);
    void ApplyCredit(CompanyCredit companyCredit);
    void Verification(CompanyCredit companyCredit);
}
