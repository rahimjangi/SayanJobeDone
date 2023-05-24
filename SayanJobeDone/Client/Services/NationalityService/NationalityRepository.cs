using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.NationalityService;

public class NationalityRepository : INationalityRepository
{
    private readonly HttpClient _httpClient;

    public NationalityRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<NationalityDto> EntityProperty { get; set; } = new List<NationalityDto>();

    public Task Add(NationalityDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<NationalityDto>>> GetAll(Expression<Func<Nationality, bool>>? filter = null, Func<IQueryable<Nationality>, IOrderedQueryable<Nationality>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<NationalityDto>> sr = new ServiceResponse<List<NationalityDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<NationalityDto>>>("api/Nationality/GetAll");
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

    public Task<ServiceResponse<NationalityDto>> GetFirstOrDefault(Expression<Func<Nationality, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(NationalityDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<NationalityDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<NationalityDto>> Update(NationalityDto entity)
    {
        throw new NotImplementedException();
    }
}
