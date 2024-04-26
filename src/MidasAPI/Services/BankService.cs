using MidasBussines;

namespace MidasAPI;

public class BankService
{
    private readonly IBankRepository _bankRep;

    public BankService(IBankRepository bankRep)
    {
        _bankRep = bankRep;
    }
    
}
