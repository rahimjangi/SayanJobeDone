using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.EducationLevelService;

public class EducationLevelRepository : IEducationLevelRepository
{
    private readonly HttpClient _httpClient;

    public EducationLevelRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<EducationLevelDto> EntityProperty { get; set; } = new List<EducationLevelDto>();

    public Task Add(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<EducationLevelDto>>> GetAll(Expression<Func<EducationLevel, bool>>? filter = null, Func<IQueryable<EducationLevel>, IOrderedQueryable<EducationLevel>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<EducationLevelDto>> sr = new ServiceResponse<List<EducationLevelDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<EducationLevelDto>>>("api/EducationLevel/GetAll");
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

    public Task<ServiceResponse<EducationLevelDto>> GetFirstOrDefault(Expression<Func<EducationLevel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<EducationLevelDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<EducationLevelDto>> Update(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }
}
