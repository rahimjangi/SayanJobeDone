using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.ServiceReceiverService;

public class ServiceReceiverRepository : IServiceReceiverRepository
{
    private readonly HttpClient _httpClient;

    public ServiceReceiverRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<ServiceReceiverDto> EntityProperty { get; set; } = new List<ServiceReceiverDto>();

    public Task Add(ServiceReceiverDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<ServiceReceiverDto>>> GetAll(Expression<Func<ServiceReceiver, bool>>? filter = null, Func<IQueryable<ServiceReceiver>, IOrderedQueryable<ServiceReceiver>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<ServiceReceiverDto>> sr = new ServiceResponse<List<ServiceReceiverDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ServiceReceiverDto>>>("api/ServiceReceiver/GetAll");
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

    public Task<ServiceResponse<ServiceReceiverDto>> GetFirstOrDefault(Expression<Func<ServiceReceiver, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceReceiverDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceReceiverDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<ServiceReceiverDto>> Update(ServiceReceiverDto entity)
    {
        throw new NotImplementedException();
    }
}
