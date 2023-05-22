using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public CountryController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    [HttpGet("[action]")]
    public async Task<ActionResult<List<CountryDto>>> GetAll()
    {
        var result = await _repo.Country.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<CountryDto>> Get(int id)
    {
        var result = await _repo.Country.GetFirstOrDefault(filter: (x => x.Id == id));
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<CountryDto>> Create(CountryDto obj)
    {
        await _repo.Country.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<CountryDto>> Update(CountryDto obj)
    {
        var updatetObject = await _repo.Country.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Country.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Country.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
