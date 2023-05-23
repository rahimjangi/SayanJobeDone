using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.ServiceService;

public class ServiceRepository : IServiceRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public ServiceRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<ServiceDto> EntityProperty { get; set; } = new List<ServiceDto>();

    public async Task Add(ServiceDto entity)
    {
        try
        {
            await _db.Services.AddAsync(_mapper.Map<Service>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<ServiceDto>>> GetAll(Expression<Func<Service, bool>>? filter = null, Func<IQueryable<Service>, IOrderedQueryable<Service>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<ServiceDto>> sr = new ServiceResponse<List<ServiceDto>>();
        try
        {
            sr.Data = _mapper.Map<List<ServiceDto>>(await _db.Services.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<ServiceDto>> GetFirstOrDefault(Expression<Func<Service, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<ServiceDto> sr = new ServiceResponse<ServiceDto>();
        try
        {
            sr.Data = _mapper.Map<ServiceDto>(await _db.Services.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(ServiceDto entity)
    {
        try
        {
            _db.Services.Remove(_mapper.Map<Service>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<ServiceDto> entities)
    {
        try
        {
            _db.Services.RemoveRange(_mapper.Map<IEnumerable<Service>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<ServiceDto>> Update(ServiceDto entity)
    {
        ServiceResponse<ServiceDto> sr = new ServiceResponse<ServiceDto>();
        try
        {
            var result = _db.Services.Update(_mapper.Map<Service>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<ServiceDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
