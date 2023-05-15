using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationDataController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public LocationDataController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
