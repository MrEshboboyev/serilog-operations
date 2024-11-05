using Microsoft.AspNetCore.Mvc;
using SerilogDemo.Services.IServices;

namespace SerilogDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController(IDummyService dummyService) : ControllerBase
{
    private IDummyService _dummyService = dummyService;

    [HttpGet]
    public void Something()
    {
        _dummyService.DoSomething();
    }
}