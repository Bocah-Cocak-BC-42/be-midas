using MidasDataAccess.Models;

namespace MidasBussines;

public class BankRepository : IBankRepository
{
    private readonly MidasContext _context;

    public BankRepository(MidasContext context)
    {
        _context = context;
    }

    public int CountData(string name) =>
        _context.Banks
        .Where(bank=>bank.Name.ToString().ToLower().Contains(name??"".ToLower()))
        .Count();

    public void Delete(string id)
    {
        try
        {
            _context.Banks.Remove(_context.Banks.First(bank=>bank.Id == id));
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public List<Bank> Get() =>
        _context.Banks
            .Where(bank=>bank.DeletedAt == null)
            .ToList();

    public List<Bank> Get(int page, int pageSize, string name) =>
        _context.Banks
            .Where(bank => 
                bank.Name.ToString().ToLower().Contains(name??"".ToLower())&&
                bank.DeletedAt == null
            )
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    public Bank? Get(string id) =>
        _context.Banks
        .FirstOrDefault(bank => bank.Id == id);
        
    public void Insert(Bank req)
    {
        try
        {
            _context.Banks.Add(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(Bank req)
    {
        try
        {
            _context.Banks.Update(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {   
            throw;
        }
    }
}
