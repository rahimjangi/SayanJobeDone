using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MobilePhoneController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public MobilePhoneController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<MobilePhoneDto>>> GetAll()
    {
        var result = await _repo.MobilePhone.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<MobilePhoneDto>> Get(int id)
    {
        var result = await _repo.MobilePhone.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<MobilePhoneDto>> Create(MobilePhoneDto obj)
    {
        await _repo.MobilePhone.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<MobilePhoneDto>> Update(MobilePhoneDto obj)
    {
        var updatetObject = await _repo.MobilePhone.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.MobilePhone.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.MobilePhone.Remove(objectFromDb);

        }
        return Ok();
    }
}
