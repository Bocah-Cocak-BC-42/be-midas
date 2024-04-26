using MidasDataAccess.Models;

namespace MidasBussines;

public interface IBankRepository
{
    List<Bank> Get();
    List<Bank> Get(int page, int pageSize, string name);
    Bank? Get(string id);
    void Insert(Bank req);
    void Update(Bank req);
    void Delete(string id);
    int CountData(string name);
}
