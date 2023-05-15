using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceReceiverController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public ServiceReceiverController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
