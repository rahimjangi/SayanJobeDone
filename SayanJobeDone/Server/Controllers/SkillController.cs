using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

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

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Skill>>> GetAll()
        {
            var result = await _repo.Skill.GetAll();

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<Skill>> Get(int id)
        {
            var result = await _repo.Skill.GetFirstOrDefault(x => x.Id == id);
            return Ok(result);
        }



        [HttpPost("[action]")]
        public async Task<ActionResult<Skill>> Create(Skill obj)
        {
            await _repo.Skill.Add(obj);
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<Skill>> Update(Skill obj)
        {
            var updatetObject = await _repo.Skill.Update(obj);
            return Ok(updatetObject);
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult> Delete(int id)
        {
            var objectFromDb = await _repo.Skill.GetFirstOrDefault(x => x.Id == id);
            if (objectFromDb != null)
            {
                await _repo.Skill.Remove(objectFromDb);

            }
            return Ok();
        }
    }
}
