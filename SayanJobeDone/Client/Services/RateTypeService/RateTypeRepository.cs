using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.RateTypeService;

public class RateTypeRepository : IRateTypeRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public RateTypeRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<RateTypeDto> EntityProperty { get; set; } = new List<RateTypeDto>();

    public async Task Add(RateTypeDto entity)
    {
        try
        {
            await _db.RateTypes.AddAsync(_mapper.Map<RateType>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<RateTypeDto>>> GetAll(Expression<Func<RateType, bool>>? filter = null, Func<IQueryable<RateType>, IOrderedQueryable<RateType>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<RateTypeDto>> sr = new ServiceResponse<List<RateTypeDto>>();
        try
        {
            sr.Data = _mapper.Map<List<RateTypeDto>>(await _db.RateTypes.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<RateTypeDto>> GetFirstOrDefault(Expression<Func<RateType, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<RateTypeDto> sr = new ServiceResponse<RateTypeDto>();
        try
        {
            sr.Data = _mapper.Map<RateTypeDto>(await _db.RateTypes.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(RateTypeDto entity)
    {
        try
        {
            _db.RateTypes.Remove(_mapper.Map<RateType>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<RateTypeDto> entities)
    {
        try
        {
            _db.RateTypes.RemoveRange(_mapper.Map<IEnumerable<RateType>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<RateTypeDto>> Update(RateTypeDto entity)
    {
        ServiceResponse<RateTypeDto> sr = new ServiceResponse<RateTypeDto>();
        try
        {
            var result = _db.RateTypes.Update(_mapper.Map<RateType>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<RateTypeDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
