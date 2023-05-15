using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public AddressController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<AddressDto>>> GetAll()
    {
        var result = await _repo.Address.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<AddressDto>> Get(int id)
    {
        var result = await _repo.Address.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<AddressDto>> Create(AddressDto address)
    {
        await _repo.Address.Add(address);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<AddressDto>> Update(AddressDto address)
    {
        var updatetObject = await _repo.Address.Update(address);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Address.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Address.Remove(objectFromDb);

        }
        return Ok();
    }



}
