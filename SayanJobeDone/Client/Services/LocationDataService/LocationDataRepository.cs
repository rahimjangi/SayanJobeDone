using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.LocationDataService;

public class LocationDataRepository : ILocationDataRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public LocationDataRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<LocationDataDto> EntityProperty { get; set; } = new List<LocationDataDto>();

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

    public async Task<ServiceResponse<List<LocationDataDto>>> GetAll(Expression<Func<LocationData, bool>>? filter = null, Func<IQueryable<LocationData>, IOrderedQueryable<LocationData>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<LocationDataDto>> sr = new ServiceResponse<List<LocationDataDto>>();
        try
        {
            sr.Data = _mapper.Map<List<LocationDataDto>>(await _db.LocationDatas.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<LocationDataDto>> GetFirstOrDefault(Expression<Func<LocationData, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<LocationDataDto> sr = new ServiceResponse<LocationDataDto>();
        try
        {
            sr.Data = _mapper.Map<LocationDataDto>(await _db.LocationDatas.FirstOrDefaultAsync(filter!));
            return sr;
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

    public async Task<ServiceResponse<LocationDataDto>> Update(LocationDataDto entity)
    {
        ServiceResponse<LocationDataDto> sr = new ServiceResponse<LocationDataDto>();
        try
        {
            var result = _db.LocationDatas.Update(_mapper.Map<LocationData>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<LocationDataDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
