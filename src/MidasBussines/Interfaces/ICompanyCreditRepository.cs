using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyCreditRepository
{   
    List<CompanyCredit> GetDraft(int page, int pageSize);
    int CountData();
    void Insert(CompanyCredit companyCredit);
}
