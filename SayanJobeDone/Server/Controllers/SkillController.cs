using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _repo;
        private readonly Mapper _mapper;

        public SkillController(IUnitOfWorkRepository repo, Mapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<SkillDto>>> GetAll()
        {
            var result = await _repo.Skill.GetAll();

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<SkillDto>> Get(int id)
        {
            var result = await _repo.Skill.GetFirstOrDefault(x => x.Id == id);
            return Ok(result);
        }



        [HttpPost("[action]")]
        public async Task<ActionResult<SkillDto>> Create(SkillDto obj)
        {
            await _repo.Skill.Add(obj);
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<SkillDto>> Update(SkillDto obj)
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
