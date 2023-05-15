using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmploymentStatusController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public EmploymentStatusController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<EmploymentStatusDto>>> GetAll()
    {
        var result = await _repo.EmploymentStatus.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<EmploymentStatusDto>> Get(int id)
    {
        //var result = await _repo.EmploymentStatus.GetFirstOrDefault(x => x.Id == id);
        return Ok(null);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<EmploymentStatusDto>> Create(EmploymentStatusDto obj)
    {
        await _repo.EmploymentStatus.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<EmploymentStatusDto>> Update(EmploymentStatusDto obj)
    {
        var updatetObject = await _repo.EmploymentStatus.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        //var objectFromDb = await _repo.EmploymentStatus.GetFirstOrDefault(x => x.Id == id);
        //if (objectFromDb != null)
        //{
        //    await _repo.EmploymentStatus.Remove(objectFromDb);

        //}
        return Ok();
    }
}
