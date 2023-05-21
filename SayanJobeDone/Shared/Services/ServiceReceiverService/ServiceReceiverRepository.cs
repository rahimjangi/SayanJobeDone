using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.ServiceReceiverService;

public class ServiceReceiverRepository : IServiceReceiverRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public ServiceReceiverRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

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

    public async Task<List<ServiceReceiverDto>> GetAll(Expression<Func<ServiceReceiver, bool>>? filter = null, Func<IQueryable<ServiceReceiver>, IOrderedQueryable<ServiceReceiver>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<ServiceReceiverDto>>(await _db.ServiceReceivers.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceReceiverDto> GetFirstOrDefault(Expression<Func<ServiceReceiver, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<ServiceReceiverDto>(await _db.ServiceReceivers.FirstOrDefaultAsync(filter!));
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

    public async Task<ServiceReceiverDto> Update(ServiceReceiverDto entity)
    {
        try
        {
            var result = _db.ServiceReceivers.Update(_mapper.Map<ServiceReceiver>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<ServiceReceiverDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
