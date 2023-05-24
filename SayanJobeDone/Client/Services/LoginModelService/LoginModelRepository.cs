using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.LoginModelService;

public class LoginModelRepository : ILoginModelRepository
{
    private readonly HttpClient _httpClient;

    public LoginModelRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<LoginModelDto> EntityProperty { get; set; } = new List<LoginModelDto>();

    public Task Add(LoginModelDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<LoginModelDto>>> GetAll(Expression<Func<LoginModel, bool>>? filter = null, Func<IQueryable<LoginModel>, IOrderedQueryable<LoginModel>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<LoginModelDto>> sr = new ServiceResponse<List<LoginModelDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<LoginModelDto>>>("api/LoginModel/GetAll");
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

    public Task<ServiceResponse<LoginModelDto>> GetFirstOrDefault(Expression<Func<LoginModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LoginModelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LoginModelDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<LoginModelDto>> Update(LoginModelDto entity)
    {
        throw new NotImplementedException();
    }
}
