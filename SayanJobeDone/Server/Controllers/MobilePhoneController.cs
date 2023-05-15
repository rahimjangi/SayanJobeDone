﻿using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MobilePhoneController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public MobilePhoneController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<MobilePhone>>> GetAll()
    {
        var result = await _repo.MobilePhone.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<MobilePhone>> Get(int id)
    {
        var result = await _repo.MobilePhone.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<MobilePhone>> Create(MobilePhone obj)
    {
        await _repo.MobilePhone.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<MobilePhone>> Update(MobilePhone obj)
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