﻿using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public LanguageController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<LanguageDto>>> GetAll()
    {
        var result = await _repo.Language.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<LanguageDto>> Get(int id)
    {
        var result = await _repo.Language.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<LanguageDto>> Create(LanguageDto obj)
    {
        await _repo.Language.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<LanguageDto>> Update(LanguageDto obj)
    {
        var updatetObject = await _repo.Language.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Language.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Language.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
