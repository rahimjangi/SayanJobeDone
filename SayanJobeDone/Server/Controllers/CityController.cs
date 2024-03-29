﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public CityController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<CityDto>>> GetAll()
    {
        var result = await _repo.City.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<CityDto>> Get(int id)
    {
        var result = await _repo.City.GetFirstOrDefault(x => x.Id == id, "Country");
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<CityDto>> Create(CityDto city)
    {
        await _repo.City.Add(city);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<CityDto>> Update(CityDto city)
    {
        var updatetObject = await _repo.City.Update(city);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.City.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.City.Remove(objectFromDb.Data!);

        }
        return Ok();
    }

}
