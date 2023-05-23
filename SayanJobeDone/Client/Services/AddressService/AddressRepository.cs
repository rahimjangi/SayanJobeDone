using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.AddressService;

public class AddressRepository : IAddressRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public AddressRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {

        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<AddressDto> EntityProperty { get; set; } = new List<AddressDto>();

    public async Task Add(AddressDto entity)
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
            var result = new AddressDto();
            if (filter != null)
            {
                result = _mapper.Map<AddressDto>(await _db.Addresses.FirstOrDefaultAsync(filter));
            }
            sr.Data = result;
            sr.Status = true;
            sr.Message = "Success";
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
            _db.Addresses.Remove(_mapper.Map<Address>(entity));
            await _db.SaveChangesAsync();
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
            _db.RemoveRange(entities);
            await _db.SaveChangesAsync();
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
            var updatedObj = _db.Addresses.Update(_mapper.Map<Address>(entity));
            await _db.SaveChangesAsync();
            var result = _mapper.Map<AddressDto>(updatedObj.Entity);
            sr.Status = true;
            sr.Data = result;
            sr.Message = "Success";
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
