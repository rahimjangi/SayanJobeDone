using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SignUpModelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public SignUpModelController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<SignUpModel>>> GetAll()
    {
        var result = await _repo.SignUpModel.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<SignUpModel>> Get(int id)
    {
        var result = await _repo.SignUpModel.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<SignUpModel>> Create(SignUpModel obj)
    {
        await _repo.SignUpModel.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<SignUpModel>> Update(SignUpModel obj)
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
            await _repo.SignUpModel.Remove(objectFromDb);

        }
        return Ok();
    }
}
