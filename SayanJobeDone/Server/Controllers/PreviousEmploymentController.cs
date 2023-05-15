using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PreviousEmploymentController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public PreviousEmploymentController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
