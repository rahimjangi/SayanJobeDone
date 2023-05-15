using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmploymentStatusController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public EmploymentStatusController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<EmploymentStatus>>> GetAll()
    {
        var result = await _repo.EmploymentStatus.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<EmploymentStatus>> Get(int id)
    {
        var result = await _repo.EmploymentStatus.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<EmploymentStatus>> Create(EmploymentStatus obj)
    {
        await _repo.EmploymentStatus.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<EmploymentStatus>> Update(EmploymentStatus obj)
    {
        var updatetObject = await _repo.EmploymentStatus.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.EmploymentStatus.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.EmploymentStatus.Remove(objectFromDb);

        }
        return Ok();
    }
}
