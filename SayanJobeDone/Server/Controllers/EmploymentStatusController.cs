using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmploymentStatusController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public EmploymentStatusController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
