using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MobilePhoneController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public MobilePhoneController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
