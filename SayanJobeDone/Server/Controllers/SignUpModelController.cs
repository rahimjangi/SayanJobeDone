using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SignUpModelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public SignUpModelController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
