using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.SkillService;

public class SkillRepository : ISkillRepository
{
    private readonly HttpClient _httpClient;

    public SkillRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<SkillDto> EntityProperty { get; set; } = new List<SkillDto>();

    public Task Add(SkillDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<SkillDto>>> GetAll(Expression<Func<Skill, bool>>? filter = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<SkillDto>> sr = new ServiceResponse<List<SkillDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<SkillDto>>>("api/Skill/GetAll");
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

    public Task<ServiceResponse<SkillDto>> GetFirstOrDefault(Expression<Func<Skill, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(SkillDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<SkillDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<SkillDto>> Update(SkillDto entity)
    {
        throw new NotImplementedException();
    }
}
