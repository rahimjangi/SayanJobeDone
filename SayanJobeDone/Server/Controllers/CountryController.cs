using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public CountryController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
