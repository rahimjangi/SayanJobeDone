using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RateTypeController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public RateTypeController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<RateTypeDto>>> GetAll()
    {
        var result = await _repo.RateType.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<RateTypeDto>> Get(int id)
    {
        var result = await _repo.RateType.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<RateTypeDto>> Create(RateTypeDto obj)
    {
        await _repo.RateType.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<RateTypeDto>> Update(RateTypeDto obj)
    {
        var updatetObject = await _repo.RateType.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.RateType.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.RateType.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
