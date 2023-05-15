using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _repo;

        public SkillController(IUnitOfWorkRepository repo)
        {
            _repo = repo;
        }
    }
}
