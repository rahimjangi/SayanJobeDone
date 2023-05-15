using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NationalityController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public NationalityController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
