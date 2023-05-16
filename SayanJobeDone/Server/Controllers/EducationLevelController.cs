using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EducationLevelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public EducationLevelController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    [HttpGet("[action]")]
    public async Task<ActionResult<List<EducationLevelDto>>> GetAll()
    {
        var result = await _repo.EducationLevel.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<EducationLevelDto>> Get(int id)
    {
        var result = await _repo.EducationLevel.GetFirstOrDefault(x => x.Id == id);
        return Ok(null);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<EducationLevelDto>> Create(EducationLevelDto obj)
    {
        await _repo.EducationLevel.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<EducationLevelDto>> Update(EducationLevelDto obj)
    {
        var updatetObject = await _repo.EducationLevel.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.EducationLevel.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.EducationLevel.Remove(objectFromDb);

        }
        return Ok();
    }
}
