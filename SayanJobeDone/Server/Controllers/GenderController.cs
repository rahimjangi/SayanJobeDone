﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenderController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public GenderController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<GenderDto>>> GetAll()
    {
        var result = await _repo.Gender.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<GenderDto>> Get(int id)
    {
        var result = await _repo.Gender.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<GenderDto>> Create(GenderDto obj)
    {
        await _repo.Gender.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<GenderDto>> Update(GenderDto obj)
    {
        var updatetObject = await _repo.Gender.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Gender.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Gender.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
