using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EducationLevelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public EducationLevelController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
    [HttpGet("[action]")]
    public async Task<ActionResult<List<EducationLevel>>> GetAll()
    {
        var result = await _repo.EducationLevel.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<EducationLevel>> Get(int id)
    {
        var result = await _repo.EducationLevel.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<EducationLevel>> Create(EducationLevel obj)
    {
        await _repo.EducationLevel.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<EducationLevel>> Update(EducationLevel obj)
    {
        var updatetObject = await _repo.EducationLevel.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.EducationLevel.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.EducationLevel.Remove(objectFromDb);

        }
        return Ok();
    }
}
