using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.NationalityService;

public class NationalityRepository : INationalityRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public NationalityRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<NationalityDto> EntityProperty { get; set; } = new List<NationalityDto>();

    public async Task Add(NationalityDto entity)
    {
        try
        {
            await _db.Nationalities.AddAsync(_mapper.Map<Nationality>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<NationalityDto>>> GetAll(Expression<Func<Nationality, bool>>? filter = null, Func<IQueryable<Nationality>, IOrderedQueryable<Nationality>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<NationalityDto>> sr = new ServiceResponse<List<NationalityDto>>();
        try
        {
            sr.Data = _mapper.Map<List<NationalityDto>>(await _db.Nationalities.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<NationalityDto>> GetFirstOrDefault(Expression<Func<Nationality, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<NationalityDto> sr = new ServiceResponse<NationalityDto>();
        try
        {
            sr.Data = _mapper.Map<NationalityDto>(await _db.Nationalities.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(NationalityDto entity)
    {
        try
        {
            _db.Nationalities.Remove(_mapper.Map<Nationality>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<NationalityDto> entities)
    {
        try
        {
            _db.Nationalities.RemoveRange(_mapper.Map<IEnumerable<Nationality>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<NationalityDto>> Update(NationalityDto entity)
    {
        ServiceResponse<NationalityDto> sr = new ServiceResponse<NationalityDto>();
        try
        {
            var result = _db.Nationalities.Update(_mapper.Map<Nationality>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<NationalityDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
