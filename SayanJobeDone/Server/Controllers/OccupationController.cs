using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OccupationController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public OccupationController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
