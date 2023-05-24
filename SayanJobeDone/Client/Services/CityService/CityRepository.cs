using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.CityService;

public class CityRepository : ICityRepository
{
    private readonly HttpClient _httpClient;

    public CityRepository(HttpClient httpClient)
    {

        _httpClient = httpClient;
    }

    public List<CityDto> EntityProperty { get; set; } = new List<CityDto>();

    public Task Add(CityDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<CityDto>>> GetAll(Expression<Func<City, bool>>? filter = null, Func<IQueryable<City>, IOrderedQueryable<City>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<CityDto>> sr = new ServiceResponse<List<CityDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<CityDto>>>("api/City/GetAll");
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

    public Task<ServiceResponse<CityDto>> GetFirstOrDefault(Expression<Func<City, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(CityDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<CityDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<CityDto>> Update(CityDto entity)
    {
        throw new NotImplementedException();
    }
}
