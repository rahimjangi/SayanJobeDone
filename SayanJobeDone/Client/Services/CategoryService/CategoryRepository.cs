using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.CagegoryService;

public class CategoryRepository : ICategoryRepository
{
    private readonly HttpClient _httpClient;


    public CategoryRepository(HttpClient httpClient)
    {

        _httpClient = httpClient;
    }

    public List<CategoryDto> EntityProperty { get; set; } = new List<CategoryDto>();

    public Task Add(CategoryDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<CategoryDto>>> GetAll(Expression<Func<Category, bool>>? filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<CategoryDto>> sr = new ServiceResponse<List<CategoryDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<CategoryDto>>>("api/Category/GetAll");
            if (result != null && result.Status && result.Data != null)
            {
                EntityProperty = result.Data;
            }
            return sr;


        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public Task<ServiceResponse<CategoryDto>> GetFirstOrDefault(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(CategoryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<CategoryDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<CategoryDto>> Update(CategoryDto entity)
    {
        throw new NotImplementedException();
    }
}
