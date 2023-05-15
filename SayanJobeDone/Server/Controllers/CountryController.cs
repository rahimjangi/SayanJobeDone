﻿using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public CountryController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
    [HttpGet("[action]")]
    public async Task<ActionResult<List<Country>>> GetAll()
    {
        var result = await _repo.Country.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<Country>> Get(int id)
    {
        var result = await _repo.Country.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<Country>> Create(Country obj)
    {
        await _repo.Country.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<Country>> Update(Country obj)
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
            await _repo.Country.Remove(objectFromDb);

        }
        return Ok();
    }
}
