using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public ServiceController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
