using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.ServiceProvidersService;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public ServiceProviderRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

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

    public async Task<List<ServiceProvidersDto>> GetAll(Expression<Func<ServiceProviders, bool>>? filter = null, Func<IQueryable<ServiceProviders>, IOrderedQueryable<ServiceProviders>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<ServiceProvidersDto>>(await _db.ServiceProviders.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceProvidersDto> GetFirstOrDefault(Expression<Func<ServiceProviders, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<ServiceProvidersDto>(await _db.ServiceProviders.FirstOrDefaultAsync(filter!));
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

    public async Task<ServiceProvidersDto> Update(ServiceProvidersDto entity)
    {
        try
        {
            var result = _db.ServiceProviders.Update(_mapper.Map<ServiceProviders>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<ServiceProvidersDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
