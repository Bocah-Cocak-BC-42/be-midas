using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

public class BankService
{
    private readonly IBankRepository _bankRep;

    public BankService(IBankRepository bankRep)
    {
        _bankRep = bankRep;
    }
    public List<BankResponseDTO> Get(int page, int pageSize, string name) =>
        _bankRep.Get(page,pageSize,name)
        .Select(bank => new BankResponseDTO
        {
            Id = bank.Id,
            Name = bank.Name
        })
        .ToList();
    public List<BankResponseDTO> Get() =>
        _bankRep.Get()
            .Select(bank => new BankResponseDTO
            {
                Id = bank.Id,
                Name = bank.Name
            })
            .ToList();
    public int CountData(string name) =>
        _bankRep.CountData(name);
    public Bank? Get(string id) => 
        _bankRep.Get(id);
    public void Insert(BankInsertDTO req) =>
        _bankRep.Insert(new Bank
            {
                Id = Guid.NewGuid().ToString(),
                Name = req.Name,
                CreatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874",
                CreatedAt = DateTime.Now
            }     
        );
    public void Update(BankUpdateDTO req)
    {
        var model = _bankRep.Get(req.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("bank"));
        model.Name = req.Name;
        model.UpdatedAt = DateTime.Now;
        model.UpdatedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        _bankRep.Update(model); 
    }
    public void Delete(string id)
    {
        var model = _bankRep.Get(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("bank"));
        model.DeletedAt = DateTime.Now;
        model.DeletedBy = "41dfada5-6c53-4c7b-8c07-89037e511874";
        _bankRep.Update(model); 
    }
}
