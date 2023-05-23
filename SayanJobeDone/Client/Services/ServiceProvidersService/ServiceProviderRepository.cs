using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.ServiceProvidersService;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public ServiceProviderRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<ServiceProvidersDto> EntityProperty { get; set; } = new List<ServiceProvidersDto>();

    public async Task Add(ServiceProvidersDto entity)
    {
        try
        {
            await _db.ServiceProviders.AddAsync(_mapper.Map<ServiceProviders>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<ServiceProvidersDto>>> GetAll(Expression<Func<ServiceProviders, bool>>? filter = null, Func<IQueryable<ServiceProviders>, IOrderedQueryable<ServiceProviders>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<ServiceProvidersDto>> sr = new ServiceResponse<List<ServiceProvidersDto>>();
        try
        {
            sr.Data = _mapper.Map<List<ServiceProvidersDto>>(await _db.ServiceProviders.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<ServiceProvidersDto>> GetFirstOrDefault(Expression<Func<ServiceProviders, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<ServiceProvidersDto> sr = new ServiceResponse<ServiceProvidersDto>();
        try
        {
            sr.Data = _mapper.Map<ServiceProvidersDto>(await _db.ServiceProviders.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(ServiceProvidersDto entity)
    {
        try
        {
            _db.ServiceProviders.Remove(_mapper.Map<ServiceProviders>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<ServiceProvidersDto> entities)
    {
        try
        {
            _db.ServiceProviders.RemoveRange(_mapper.Map<IEnumerable<ServiceProviders>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<ServiceProvidersDto>> Update(ServiceProvidersDto entity)
    {
        ServiceResponse<ServiceProvidersDto> sr = new ServiceResponse<ServiceProvidersDto>();
        try
        {
            var result = _db.ServiceProviders.Update(_mapper.Map<ServiceProviders>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<ServiceProvidersDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
