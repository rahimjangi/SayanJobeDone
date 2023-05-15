using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EducationLevelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public EducationLevelController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
