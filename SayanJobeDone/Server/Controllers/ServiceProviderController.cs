using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceProviderController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public ServiceProviderController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<ServiceProvidersDto>>> GetAll()
    {
        var result = await _repo.ServiceProviders.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<ServiceProvidersDto>> Get(int id)
    {
        var result = await _repo.ServiceProviders.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<ServiceProvidersDto>> Create(ServiceProvidersDto obj)
    {
        await _repo.ServiceProviders.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<ServiceProvidersDto>> Update(ServiceProvidersDto obj)
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
            await _repo.ServiceProviders.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
