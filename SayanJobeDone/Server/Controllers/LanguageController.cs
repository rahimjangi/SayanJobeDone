using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public LanguageController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
