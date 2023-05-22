using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Services;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public AddressController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<ServiceResponse<List<AddressDto>>>> GetAll()
    {
        var result = await _repo.Address.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<ServiceResponse<AddressDto>>> Get(int id)
    {
        var result = await _repo.Address.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<ServiceResponse<AddressDto>>> Create(AddressDto address)
    {
        await _repo.Address.Add(address);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<ServiceResponse<AddressDto>>> Update(AddressDto address)
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
            await _repo.Address.Remove(objectFromDb.Data!);

        }
        return Ok();
    }



}
