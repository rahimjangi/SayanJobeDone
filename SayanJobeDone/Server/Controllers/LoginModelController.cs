using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginModelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public LoginModelController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
