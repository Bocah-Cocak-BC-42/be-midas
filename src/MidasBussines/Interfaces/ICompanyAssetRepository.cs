using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface ICompanyAssetRepository
{
    void Insert(CompanyAsset companyAsset);
    void Update(CompanyAsset companyAsset);
    void Delete(string companyAssetId);
}
