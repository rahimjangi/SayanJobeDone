using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public CityController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<CityDto>>> GetAll()
    {
        var result = await _repo.City.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<CityDto>> Get(int id)
    {
        var result = await _repo.City.GetFirstOrDefault(x => x.Id == id, "Country");
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<CityDto>> Create(CityDto city)
    {
        await _repo.City.Add(city);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<CityDto>> Update(CityDto city)
    {
        var updatetObject = await _repo.City.Update(city);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.City.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.City.Remove(objectFromDb);

        }
        return Ok();
    }

}
