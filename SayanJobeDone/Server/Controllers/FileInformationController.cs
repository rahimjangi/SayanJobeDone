using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileInformationController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public FileInformationController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
