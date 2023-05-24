using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.MobilePhoneService;

public class MobilePhoneRepository : IMobilePhoneRepository
{
    private readonly HttpClient _httpClient;

    public MobilePhoneRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<MobilePhoneDto> EntityProperty { get; set; } = new List<MobilePhoneDto>();

    public Task Add(MobilePhoneDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<MobilePhoneDto>>> GetAll(Expression<Func<MobilePhone, bool>>? filter = null, Func<IQueryable<MobilePhone>, IOrderedQueryable<MobilePhone>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<MobilePhoneDto>> sr = new ServiceResponse<List<MobilePhoneDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<MobilePhoneDto>>>("api/MobilePhone/GetAll");
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

    public Task<ServiceResponse<MobilePhoneDto>> GetFirstOrDefault(Expression<Func<MobilePhone, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(MobilePhoneDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<MobilePhoneDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<MobilePhoneDto>> Update(MobilePhoneDto entity)
    {
        throw new NotImplementedException();
    }
}
