using Microsoft.AspNetCore.Mvc;

namespace LifetimeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LifetimeController : ControllerBase
{
    private readonly Service _service;

    public LifetimeController(Service service)
    {
        _service = service;
    }

    [HttpGet]
    public void CheckLifeTimes()
    {
        Console.WriteLine("Values of ids in this request:");
        _service.Run();
    }
}