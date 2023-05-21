using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.LocationDataService;

public class LocationDataRepository : ILocationDataRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public LocationDataRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(LocationDataDto entity)
    {
        try
        {
            await _db.LocationDatas.AddAsync(_mapper.Map<LocationData>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<LocationDataDto>> GetAll(Expression<Func<LocationData, bool>>? filter = null, Func<IQueryable<LocationData>, IOrderedQueryable<LocationData>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<LocationDataDto>>(await _db.LocationDatas.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<LocationDataDto> GetFirstOrDefault(Expression<Func<LocationData, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<LocationDataDto>(await _db.LocationDatas.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(LocationDataDto entity)
    {
        try
        {
            _db.LocationDatas.Remove(_mapper.Map<LocationData>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<LocationDataDto> entities)
    {
        try
        {
            _db.LocationDatas.RemoveRange(_mapper.Map<IEnumerable<LocationData>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<LocationDataDto> Update(LocationDataDto entity)
    {
        try
        {
            var result = _db.LocationDatas.Update(_mapper.Map<LocationData>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<LocationDataDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
