using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.ServiceProvidersService;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly HttpClient _httpClient;

    public ServiceProviderRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<ServiceProvidersDto> EntityProperty { get; set; } = new List<ServiceProvidersDto>();

    public Task Add(ServiceProvidersDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<ServiceProvidersDto>>> GetAll(Expression<Func<ServiceProviders, bool>>? filter = null, Func<IQueryable<ServiceProviders>, IOrderedQueryable<ServiceProviders>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<ServiceProvidersDto>> sr = new ServiceResponse<List<ServiceProvidersDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ServiceProvidersDto>>>("api/ServiceProviders/GetAll");
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

    public Task<ServiceResponse<ServiceProvidersDto>> GetFirstOrDefault(Expression<Func<ServiceProviders, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceProvidersDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceProvidersDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<ServiceProvidersDto>> Update(ServiceProvidersDto entity)
    {
        throw new NotImplementedException();
    }
}
