using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenderController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public GenderController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<Gender>>> GetAll()
    {
        var result = await _repo.Gender.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<Gender>> Get(int id)
    {
        var result = await _repo.Gender.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<Gender>> Create(Gender obj)
    {
        await _repo.Gender.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<Gender>> Update(Gender obj)
    {
        var updatetObject = await _repo.Gender.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Gender.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Gender.Remove(objectFromDb);

        }
        return Ok();
    }
}
