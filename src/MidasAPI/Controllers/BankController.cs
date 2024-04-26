using Microsoft.AspNetCore.Mvc;

namespace MidasAPI;

public class BankController : ControllerBase
{
    private readonly BankService _service;

    public BankController(BankService service)
    {
        _service = service;
    }

}
