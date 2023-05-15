using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileInformationController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public FileInformationController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<FileInformationDto>>> GetAll()
    {
        var result = await _repo.FileInformation.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<FileInformationDto>> Get(int id)
    {
        var result = await _repo.FileInformation.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<FileInformationDto>> Create(FileInformationDto obj)
    {
        await _repo.FileInformation.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<FileInformationDto>> Update(FileInformationDto obj)
    {
        var updatetObject = await _repo.FileInformation.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.FileInformation.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.FileInformation.Remove(objectFromDb);

        }
        return Ok();
    }
}
