using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceProviderController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public ServiceProviderController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<ServiceProviders>>> GetAll()
    {
        var result = await _repo.ServiceProviders.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<ServiceProviders>> Get(int id)
    {
        var result = await _repo.ServiceProviders.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<ServiceProviders>> Create(ServiceProviders obj)
    {
        await _repo.ServiceProviders.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<ServiceProviders>> Update(ServiceProviders obj)
    {
        var updatetObject = await _repo.ServiceProviders.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.ServiceProviders.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.ServiceProviders.Remove(objectFromDb);

        }
        return Ok();
    }
}
