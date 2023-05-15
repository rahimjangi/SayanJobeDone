using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NationalityController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public NationalityController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<NationalityDto>>> GetAll()
    {
        var result = await _repo.Nationality.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<NationalityDto>> Get(int id)
    {
        var result = await _repo.Nationality.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<NationalityDto>> Create(NationalityDto obj)
    {
        await _repo.Nationality.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<NationalityDto>> Update(NationalityDto obj)
    {
        var updatetObject = await _repo.Nationality.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Nationality.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Nationality.Remove(objectFromDb);

        }
        return Ok();
    }
}
