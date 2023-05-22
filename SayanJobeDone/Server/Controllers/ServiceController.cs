using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public ServiceController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<ServiceDto>>> GetAll()
    {
        var result = await _repo.Service.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<ServiceDto>> Get(int id)
    {
        var result = await _repo.Service.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<ServiceDto>> Create(ServiceDto obj)
    {
        await _repo.Service.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<ServiceDto>> Update(ServiceDto obj)
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
            await _repo.Service.Remove(objectFromDb.Data!);

        }
        return Ok();
    }

}
