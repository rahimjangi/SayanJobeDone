using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.CagegoryService;

public class CategoryRepository : ICategoryRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CategoryRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<CategoryDto> EntityProperty { get; set; } = new List<CategoryDto>();

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

    public async Task<ServiceResponse<List<CategoryDto>>> GetAll(Expression<Func<Category, bool>>? filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<CategoryDto>> sr = new ServiceResponse<List<CategoryDto>>();
        try
        {
            var result = _mapper.Map<List<CategoryDto>>(await _db.Categories.ToListAsync());
            sr.Data = result;
            sr.Message = "Success";
            sr.Status = true;
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<CategoryDto>> GetFirstOrDefault(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<CategoryDto> sr = new ServiceResponse<CategoryDto>();
        try
        {
            var result = _mapper.Map<CategoryDto>(await _db.Categories.FirstOrDefaultAsync(filter!));
            sr.Data = result;
            sr.Message = "Success";
            sr.Status = true;
            return sr;
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

    public async Task<ServiceResponse<CategoryDto>> Update(CategoryDto entity)
    {
        ServiceResponse<CategoryDto> sr = new ServiceResponse<CategoryDto>();
        try
        {
            var result = _mapper.Map<CategoryDto>(_db.Categories.Update(_mapper.Map<Category>(entity)));
            await _db.SaveChangesAsync();
            sr.Data = result;
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
