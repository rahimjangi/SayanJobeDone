using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.RateTypeService;

public class RateTypeRepository : IRateTypeRepository
{
    private readonly HttpClient _httpClient;

    public RateTypeRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<RateTypeDto> EntityProperty { get; set; } = new List<RateTypeDto>();

    public Task Add(RateTypeDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<RateTypeDto>>> GetAll(Expression<Func<RateType, bool>>? filter = null, Func<IQueryable<RateType>, IOrderedQueryable<RateType>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<RateTypeDto>> sr = new ServiceResponse<List<RateTypeDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<RateTypeDto>>>("api/RateType/GetAll");
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

    public Task<ServiceResponse<RateTypeDto>> GetFirstOrDefault(Expression<Func<RateType, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(RateTypeDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<RateTypeDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<RateTypeDto>> Update(RateTypeDto entity)
    {
        throw new NotImplementedException();
    }
}
