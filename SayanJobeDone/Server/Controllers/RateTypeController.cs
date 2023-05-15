﻿using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RateTypeController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public RateTypeController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }
}
