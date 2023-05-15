using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationDataController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public LocationDataController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<LocationData>>> GetAll()
    {
        var result = await _repo.LocationData.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<LocationData>> Get(int id)
    {
        var result = await _repo.LocationData.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<LocationData>> Create(LocationData obj)
    {
        await _repo.LocationData.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<LocationData>> Update(LocationData obj)
    {
        var updatetObject = await _repo.LocationData.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.LocationData.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.LocationData.Remove(objectFromDb);

        }
        return Ok();
    }
}
