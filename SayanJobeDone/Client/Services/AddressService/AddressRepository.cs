using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.AddressService;

public class AddressRepository : IAddressRepository
{
    private readonly HttpClient _httpClient;

    public AddressRepository(HttpClient httpClient)
    {

        _httpClient = httpClient;
    }

    public List<AddressDto> EntityProperty { get; set; } = new List<AddressDto>();

    public Task Add(AddressDto entity)
    {
        try
        {

        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<AddressDto>>> GetAll(Expression<Func<Address, bool>>? filter = null, Func<IQueryable<Address>, IOrderedQueryable<Address>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<AddressDto>> sr = new ServiceResponse<List<AddressDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<AddressDto>>>("api/Address/GetAll");
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

    public async Task<ServiceResponse<AddressDto>> GetFirstOrDefault(Expression<Func<Address, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<AddressDto> sr = new ServiceResponse<AddressDto>();
        try
        {

            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task Remove(AddressDto entity)
    {
        try
        {

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);

        }
    }

    public async Task RemoveRange(IEnumerable<AddressDto> entities)
    {
        try
        {

        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<AddressDto>> Update(AddressDto entity)
    {
        ServiceResponse<AddressDto> sr = new ServiceResponse<AddressDto>();
        try
        {

            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
