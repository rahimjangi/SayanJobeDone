using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceReceiverController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public ServiceReceiverController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<ServiceReceiverDto>>> GetAll()
    {
        var result = await _repo.ServiceReceiver.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<ServiceReceiverDto>> Get(int id)
    {
        var result = await _repo.ServiceReceiver.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<ServiceReceiverDto>> Create(ServiceReceiverDto obj)
    {
        await _repo.ServiceReceiver.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<ServiceReceiverDto>> Update(ServiceReceiverDto obj)
    {
        var updatetObject = await _repo.ServiceReceiver.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.ServiceReceiver.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.ServiceReceiver.Remove(objectFromDb);

        }
        return Ok();
    }
}
