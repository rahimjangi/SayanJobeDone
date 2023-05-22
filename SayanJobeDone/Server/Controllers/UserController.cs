using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _repo;
        private readonly Mapper _mapper;

        public UserController(IUnitOfWorkRepository repo, Mapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<UserDto>>> GetAll()
        {
            var result = await _repo.User.GetAll();

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<UserDto>> Get(int id)
        {
            var result = await _repo.User.GetFirstOrDefault(x => x.Id == id);
            return Ok(result);
        }




        [HttpPost("[action]")]
        public async Task<ActionResult<UserDto>> Create(UserDto obj)
        {
            await _repo.User.Add(obj);
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<UserDto>> Update(UserDto obj)
        {
            var updatetObject = await _repo.User.Update(obj);
            return Ok(updatetObject);
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult> Delete(int id)
        {
            var objectFromDb = await _repo.User.GetFirstOrDefault(x => x.Id == id);
            if (objectFromDb != null)
            {
                await _repo.User.Remove(objectFromDb.Data!);

            }
            return Ok();
        }
    }
}
