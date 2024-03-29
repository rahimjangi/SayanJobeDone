﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PreviousEmploymentController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public PreviousEmploymentController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<PreviousEmploymentDto>>> GetAll()
    {
        var result = await _repo.PreviousEmployment.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<PreviousEmploymentDto>> Get(int id)
    {
        var result = await _repo.PreviousEmployment.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<PreviousEmploymentDto>> Create(PreviousEmploymentDto obj)
    {
        await _repo.PreviousEmployment.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<PreviousEmploymentDto>> Update(PreviousEmploymentDto obj)
    {
        var updatetObject = await _repo.PreviousEmployment.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.PreviousEmployment.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.PreviousEmployment.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
