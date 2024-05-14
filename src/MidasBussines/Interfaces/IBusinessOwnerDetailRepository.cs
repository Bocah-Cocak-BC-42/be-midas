using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IBusinessOwnerDetailRepository
{   
    BusinessOwnerDetail? GetById(string id);
    void Insert(BusinessOwnerDetail businessOwnerDetail);
    void Update(BusinessOwnerDetail businessOwnerDetail);
    void Delete(string companyId);
}
