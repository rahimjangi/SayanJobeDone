using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.OccupationService;

public class OccupationRepository : IOccupationRepository
{
    private readonly HttpClient _httpClient;

    public OccupationRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<OccupationDto> EntityProperty { get; set; } = new List<OccupationDto>();

    public Task Add(OccupationDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<OccupationDto>>> GetAll(Expression<Func<Occupation, bool>>? filter = null, Func<IQueryable<Occupation>, IOrderedQueryable<Occupation>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<OccupationDto>> sr = new ServiceResponse<List<OccupationDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<OccupationDto>>>("api/Occupation/GetAll");
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

    public Task<ServiceResponse<OccupationDto>> GetFirstOrDefault(Expression<Func<Occupation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(OccupationDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<OccupationDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<OccupationDto>> Update(OccupationDto entity)
    {
        throw new NotImplementedException();
    }
}
