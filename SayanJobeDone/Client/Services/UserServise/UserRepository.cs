using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.UserServise;

public class UserRepository : IUserRepository
{
    private readonly HttpClient _httpClient;

    public UserRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<UserDto> EntityProperty { get; set; } = new List<UserDto>();

    public Task Add(UserDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<UserDto>>> GetAll(Expression<Func<User, bool>>? filter = null, Func<IQueryable<User>, IOrderedQueryable<User>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<UserDto>> sr = new ServiceResponse<List<UserDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<UserDto>>>("api/User/GetAll");
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

    public Task<ServiceResponse<UserDto>> GetFirstOrDefault(Expression<Func<User, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(UserDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<UserDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<UserDto>> Update(UserDto entity)
    {
        throw new NotImplementedException();
    }
}
