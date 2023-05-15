using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OccupationController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public OccupationController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<OccupationDto>>> GetAll()
    {
        var result = await _repo.Occupation.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<OccupationDto>> Get(int id)
    {
        var result = await _repo.Occupation.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<OccupationDto>> Create(OccupationDto obj)
    {
        await _repo.Occupation.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<OccupationDto>> Update(OccupationDto obj)
    {
        var updatetObject = await _repo.Occupation.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Occupation.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Occupation.Remove(objectFromDb);

        }
        return Ok();
    }
}
