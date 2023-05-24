using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.LanguageService;

public class LanguageRepository : ILanguageRepository
{
    private readonly HttpClient _httpClient;

    public LanguageRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<LanguageDto> EntityProperty { get; set; } = new List<LanguageDto>();

    public Task Add(LanguageDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<LanguageDto>>> GetAll(Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<LanguageDto>> sr = new ServiceResponse<List<LanguageDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<LanguageDto>>>("api/Language/GetAll");
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

    public Task<ServiceResponse<LanguageDto>> GetFirstOrDefault(Expression<Func<Language, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LanguageDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LanguageDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<LanguageDto>> Update(LanguageDto entity)
    {
        throw new NotImplementedException();
    }
}
