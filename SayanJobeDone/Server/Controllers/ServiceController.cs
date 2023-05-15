using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public ServiceController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<Service>>> GetAll()
    {
        var result = await _repo.Service.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<Service>> Get(int id)
    {
        var result = await _repo.Service.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<Service>> Create(Service obj)
    {
        await _repo.Service.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<Service>> Update(Service obj)
    {
        var updatetObject = await _repo.Service.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Service.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Service.Remove(objectFromDb);

        }
        return Ok();
    }

}
