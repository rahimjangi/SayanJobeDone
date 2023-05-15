using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceProviderController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public ServiceProviderController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
