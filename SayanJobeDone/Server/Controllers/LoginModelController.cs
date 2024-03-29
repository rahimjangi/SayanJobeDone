﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginModelController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;
    private readonly Mapper _mapper;

    public LoginModelController(IUnitOfWorkRepository repo, Mapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<LoginModelDto>>> GetAll()
    {
        var result = await _repo.LoginModel.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<LoginModelDto>> Get(int id)
    {
        var result = await _repo.LoginModel.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }



    [HttpPost("[action]")]
    public async Task<ActionResult<LoginModelDto>> Create(LoginModelDto obj)
    {
        await _repo.LoginModel.Add(obj);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<LoginModelDto>> Update(LoginModelDto obj)
    {
        var updatetObject = await _repo.LoginModel.Update(obj);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.LoginModel.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.LoginModel.Remove(objectFromDb.Data!);

        }
        return Ok();
    }
}
