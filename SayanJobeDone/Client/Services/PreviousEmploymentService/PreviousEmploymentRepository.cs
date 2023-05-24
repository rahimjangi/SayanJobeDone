using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.PreviousEmploymentService;

public class PreviousEmploymentRepository : IPreviousEmploymentRepository
{
    private readonly HttpClient _httpClient;

    public PreviousEmploymentRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<PreviousEmploymentDto> EntityProperty { get; set; } = new List<PreviousEmploymentDto>();

    public Task Add(PreviousEmploymentDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<PreviousEmploymentDto>>> GetAll(Expression<Func<PreviousEmployment, bool>>? filter = null, Func<IQueryable<PreviousEmployment>, IOrderedQueryable<PreviousEmployment>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<PreviousEmploymentDto>> sr = new ServiceResponse<List<PreviousEmploymentDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<PreviousEmploymentDto>>>("api/PreviousEmployment/GetAll");
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

    public Task<ServiceResponse<PreviousEmploymentDto>> GetFirstOrDefault(Expression<Func<PreviousEmployment, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(PreviousEmploymentDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<PreviousEmploymentDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<PreviousEmploymentDto>> Update(PreviousEmploymentDto entity)
    {
        throw new NotImplementedException();
    }
}
