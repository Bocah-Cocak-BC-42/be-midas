using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasBussines.Repositories;

public class BusinessOwnerDetailRepository : IBusinessOwnerDetailRepository
{
    private readonly MidasContext _dbContext;

    public BusinessOwnerDetailRepository(MidasContext dbContext)
    {
        _dbContext = dbContext;
    }


    public void Insert(BusinessOwnerDetail businessOwnerDetail)
    {
        _dbContext.BusinessOwnerDetails.Add(businessOwnerDetail);
        _dbContext.SaveChanges();
    }

    public void Update(BusinessOwnerDetail businessOwnerDetail)
    {
        _dbContext.BusinessOwnerDetails.Update(businessOwnerDetail);
        _dbContext.SaveChanges();
    }

    public void Delete(string companyId)
    {       
        var businessOwnerDetail = _dbContext.BusinessOwnerDetails.Where(b => b.CompanyId == companyId);
        _dbContext.BusinessOwnerDetails.RemoveRange(businessOwnerDetail);
        _dbContext.SaveChanges();
    }

    public BusinessOwnerDetail? GetById(string id)
    {
        return _dbContext.BusinessOwnerDetails.Find(id);
    }
}
