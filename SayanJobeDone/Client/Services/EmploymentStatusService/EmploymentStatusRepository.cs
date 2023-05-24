using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.EmploymentStatusService;

public class EmploymentStatusRepository : IEmploymentStatusRepository
{
    private readonly HttpClient _httpClient;

    public EmploymentStatusRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<EmploymentStatusDto> EntityProperty { get; set; } = new List<EmploymentStatusDto>();

    public Task Add(EmploymentStatusDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<EmploymentStatusDto>>> GetAll(Expression<Func<EmploymentStatus, bool>>? filter = null, Func<IQueryable<EmploymentStatus>, IOrderedQueryable<EmploymentStatus>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<EmploymentStatusDto>> sr = new ServiceResponse<List<EmploymentStatusDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<EmploymentStatusDto>>>("api/EmploymentStatus/GetAll");
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

    public Task<ServiceResponse<EmploymentStatusDto>> GetFirstOrDefault(Expression<Func<EmploymentStatus, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(EmploymentStatusDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<EmploymentStatusDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<EmploymentStatusDto>> Update(EmploymentStatusDto entity)
    {
        throw new NotImplementedException();
    }
}
