using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenderController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public GenderController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
