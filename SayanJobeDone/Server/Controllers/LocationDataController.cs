﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationDataController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public LocationDataController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<LocationDataDto>>> GetAll()
    {
        var result = await _repo.LocationData.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<LocationDataDto>> Get(int id)
    {
        var result = await _repo.LocationData.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }


    [HttpPost("[action]")]
    public async Task<ActionResult<LocationDataDto>> Create(LocationDataDto obj)
    {
        await _repo.LocationData.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<LocationDataDto>> Update(LocationDataDto obj)
    {
        var updatetObject = await _repo.LocationData.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.LocationData.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.LocationData.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
