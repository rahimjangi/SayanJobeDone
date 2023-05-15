using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileInformationController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public FileInformationController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<FileInformation>>> GetAll()
    {
        var result = await _repo.FileInformation.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<FileInformation>> Get(int id)
    {
        var result = await _repo.FileInformation.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<FileInformation>> Create(FileInformation obj)
    {
        await _repo.FileInformation.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<FileInformation>> Update(FileInformation obj)
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
