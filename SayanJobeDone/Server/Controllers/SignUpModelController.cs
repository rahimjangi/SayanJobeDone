using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SignUpModelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public SignUpModelController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<SignUpModelDto>>> GetAll()
    {
        var result = await _repo.SignUpModel.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<SignUpModelDto>> Get(int id)
    {
        var result = await _repo.SignUpModel.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<SignUpModelDto>> Create(SignUpModelDto obj)
    {
        await _repo.SignUpModel.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<SignUpModelDto>> Update(SignUpModelDto obj)
    {
        var updatetObject = await _repo.SignUpModel.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.SignUpModel.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.SignUpModel.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
