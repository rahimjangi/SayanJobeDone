using Microsoft.AspNetCore.Mvc;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IUnitOfWorkRepository _repo;

    public CategoryController(IUnitOfWorkRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<List<CategoryDto>>> GetAll()
    {
        var result = await _repo.Category.GetAll();

        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<CategoryDto>> Get(int id)
    {
        var result = await _repo.Category.GetFirstOrDefault(x => x.Id == id);
        return Ok(result);
    }
    [HttpPost("[action]")]
    public async Task<ActionResult<CategoryDto>> Create(CategoryDto category)
    {
        await _repo.Category.Add(category);
        return Ok();
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<CategoryDto>> Update(CategoryDto category)
    {
        var updatetObject = await _repo.Category.Update(category);
        return Ok(updatetObject);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult> Delete(int id)
    {
        var objectFromDb = await _repo.Category.GetFirstOrDefault(x => x.Id == id);
        if (objectFromDb != null)
        {
            await _repo.Category.Remove(objectFromDb);

        }
        return Ok();
    }

}
