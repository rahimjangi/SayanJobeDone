using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.CategoryService;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CategoryRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(CategoryDto entity)
    {
        try
        {
            var category = _mapper.Map<Category>(entity);
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<CategoryDto>> GetAll(Expression<Func<Category, bool>>? filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<CategoryDto>>(await _db.Categories.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<CategoryDto> GetFirstOrDefault(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<CategoryDto>(await _db.Categories.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(CategoryDto entity)
    {
        try
        {
            _db.Categories.Remove(_mapper.Map<Category>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<CategoryDto> entities)
    {
        try
        {
            _db.Categories.RemoveRange(_mapper.Map<Category>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<CategoryDto> Update(CategoryDto entity)
    {
        try
        {
            var result = _mapper.Map<CategoryDto>(_db.Categories.Update(_mapper.Map<Category>(entity)));
            await _db.SaveChangesAsync();
            return result;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
