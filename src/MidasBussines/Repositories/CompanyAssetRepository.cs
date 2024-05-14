using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class CompanyAssetRepository : ICompanyAssetRepository
{
    private readonly MidasContext _dbContext;

    public CompanyAssetRepository(MidasContext dbContext)
    {
        _dbContext = dbContext;
    }

    

    public void Insert(CompanyAsset companyAsset)
    {
        _dbContext.CompanyAssets.Add(companyAsset);
        _dbContext.SaveChanges();
    }

    public void Update(CompanyAsset companyAsset)
    {
        throw new NotImplementedException();
    }

    public void Delete(string companyId)
    {
        var companyAsset = _dbContext.CompanyAssets.Where(c => c.CompanyId == companyId);
        _dbContext.CompanyAssets.RemoveRange();
        _dbContext.SaveChanges();
    }
}
