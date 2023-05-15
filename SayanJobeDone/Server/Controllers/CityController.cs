using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public CityController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

}
