using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.ServiceService;

public class ServiceRepository : IServiceRepository
{
    private readonly HttpClient _httpClient;

    public ServiceRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<ServiceDto> EntityProperty { get; set; } = new List<ServiceDto>();

    public Task Add(ServiceDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<ServiceDto>>> GetAll(Expression<Func<Service, bool>>? filter = null, Func<IQueryable<Service>, IOrderedQueryable<Service>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<ServiceDto>> sr = new ServiceResponse<List<ServiceDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ServiceDto>>>("api/Service/GetAll");
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

    public Task<ServiceResponse<ServiceDto>> GetFirstOrDefault(Expression<Func<Service, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<ServiceDto>> Update(ServiceDto entity)
    {
        throw new NotImplementedException();
    }
}
