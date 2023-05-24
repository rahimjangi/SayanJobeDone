using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.GenderService;

public class GenderRepository : IGenderRepository
{
    private readonly HttpClient _httpClient;

    public GenderRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<GenderDto> EntityProperty { get; set; } = new List<GenderDto>();

    public Task Add(GenderDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<GenderDto>>> GetAll(Expression<Func<Gender, bool>>? filter = null, Func<IQueryable<Gender>, IOrderedQueryable<Gender>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<GenderDto>> sr = new ServiceResponse<List<GenderDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenderDto>>>("api/Gender/GetAll");
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

    public Task<ServiceResponse<GenderDto>> GetFirstOrDefault(Expression<Func<Gender, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(GenderDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<GenderDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<GenderDto>> Update(GenderDto entity)
    {
        throw new NotImplementedException();
    }
}
