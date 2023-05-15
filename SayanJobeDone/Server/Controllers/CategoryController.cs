using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public CategoryController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

}
