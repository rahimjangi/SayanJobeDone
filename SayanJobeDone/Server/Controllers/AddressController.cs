using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public AddressController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }


}
