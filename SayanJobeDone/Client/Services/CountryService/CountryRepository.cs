using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.CountryService;
public class CountryRepository : ICountryRepository
{
    private readonly HttpClient _httpClient;

    public CountryRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<CountryDto> EntityProperty { get; set; } = new List<CountryDto>();

    public Task Add(CountryDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<CountryDto>>> GetAll(Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<CountryDto>> sr = new ServiceResponse<List<CountryDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<CountryDto>>>("api/Country/GetAll");
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

    public Task<ServiceResponse<CountryDto>> GetFirstOrDefault(Expression<Func<Country, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(CountryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<CountryDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<CountryDto>> Update(CountryDto entity)
    {
        throw new NotImplementedException();
    }
}
