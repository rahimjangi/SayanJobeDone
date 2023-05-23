using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.ServiceReceiverService;

public class ServiceReceiverRepository : IServiceReceiverRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public ServiceReceiverRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<ServiceReceiverDto> EntityProperty { get; set; } = new List<ServiceReceiverDto>();

    public async Task Add(ServiceReceiverDto entity)
    {
        try
        {
            await _db.ServiceReceivers.AddAsync(_mapper.Map<ServiceReceiver>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<ServiceReceiverDto>>> GetAll(Expression<Func<ServiceReceiver, bool>>? filter = null, Func<IQueryable<ServiceReceiver>, IOrderedQueryable<ServiceReceiver>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<ServiceReceiverDto>> sr = new ServiceResponse<List<ServiceReceiverDto>>();
        try
        {
            sr.Data = _mapper.Map<List<ServiceReceiverDto>>(await _db.ServiceReceivers.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<ServiceReceiverDto>> GetFirstOrDefault(Expression<Func<ServiceReceiver, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<ServiceReceiverDto> sr = new ServiceResponse<ServiceReceiverDto>();
        try
        {
            sr.Data = _mapper.Map<ServiceReceiverDto>(await _db.ServiceReceivers.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(ServiceReceiverDto entity)
    {
        try
        {
            _db.ServiceReceivers.Remove(_mapper.Map<ServiceReceiver>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<ServiceReceiverDto> entities)
    {
        try
        {
            _db.ServiceReceivers.RemoveRange(_mapper.Map<IEnumerable<ServiceReceiver>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<ServiceReceiverDto>> Update(ServiceReceiverDto entity)
    {
        ServiceResponse<ServiceReceiverDto> sr = new ServiceResponse<ServiceReceiverDto>();
        try
        {
            var result = _db.ServiceReceivers.Update(_mapper.Map<ServiceReceiver>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<ServiceReceiverDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
