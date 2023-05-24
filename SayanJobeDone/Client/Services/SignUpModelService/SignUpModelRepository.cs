using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.SignUpModelService;

public class SignUpModelRepository : ISignUpModelRepository
{
    private readonly HttpClient _httpClient;

    public SignUpModelRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<SignUpModelDto> EntityProperty { get; set; } = new List<SignUpModelDto>();

    public Task Add(SignUpModelDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<SignUpModelDto>>> GetAll(Expression<Func<SignUpModel, bool>>? filter = null, Func<IQueryable<SignUpModel>, IOrderedQueryable<SignUpModel>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<SignUpModelDto>> sr = new ServiceResponse<List<SignUpModelDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<SignUpModelDto>>>("api/SignUpModel/GetAll");
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

    public Task<ServiceResponse<SignUpModelDto>> GetFirstOrDefault(Expression<Func<SignUpModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(SignUpModelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<SignUpModelDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<SignUpModelDto>> Update(SignUpModelDto entity)
    {
        throw new NotImplementedException();
    }
}
