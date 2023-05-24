using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.LocationDataService;

public class LocationDataRepository : ILocationDataRepository
{
    private readonly HttpClient _httpClient;

    public LocationDataRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<LocationDataDto> EntityProperty { get; set; } = new List<LocationDataDto>();

    public Task Add(LocationDataDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<LocationDataDto>>> GetAll(Expression<Func<LocationData, bool>>? filter = null, Func<IQueryable<LocationData>, IOrderedQueryable<LocationData>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<LocationDataDto>> sr = new ServiceResponse<List<LocationDataDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<LocationDataDto>>>("api/LocationData/GetAll");
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

    public Task<ServiceResponse<LocationDataDto>> GetFirstOrDefault(Expression<Func<LocationData, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LocationDataDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LocationDataDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<LocationDataDto>> Update(LocationDataDto entity)
    {
        throw new NotImplementedException();
    }
}
