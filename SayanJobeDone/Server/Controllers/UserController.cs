using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _repo;

        public UserController(IUnitOfWorkRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {

            return Ok();
        }
    }
}
