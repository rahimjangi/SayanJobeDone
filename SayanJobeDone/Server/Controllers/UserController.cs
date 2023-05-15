using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

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
        public async Task<ActionResult<List<User>>> GetAll()
        {
            var result = await _repo.User.GetAll();

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var result = await _repo.User.GetFirstOrDefault(x => x.Id == id);
            return Ok(result);
        }




        [HttpPost("[action]")]
        public async Task<ActionResult<User>> Create(User obj)
        {
            await _repo.User.Add(obj);
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<User>> Update(User obj)
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
                await _repo.User.Remove(objectFromDb);

            }
            return Ok();
        }
    }
}
