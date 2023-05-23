using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.CountryService;
public class CountryRepository : ICountryRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CountryRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<CountryDto> EntityProperty { get; set; } = new List<CountryDto>();

    public async Task Add(CountryDto entity)
    {
        try
        {
            _db.Countries.Add(_mapper.Map<Country>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<CountryDto>>> GetAll(Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<CountryDto>> sr = new ServiceResponse<List<CountryDto>>();
        try
        {
            if (filter != null)
            {
                var countryFilter = _mapper.Map<Expression<Func<Country, bool>>, Expression<Func<Country, bool>>>(filter);
                var listOfCountry = await _db.Countries.Where(countryFilter).ToListAsync();
                var result = _mapper.Map<List<CountryDto>>(listOfCountry);
                sr.Data = result;
                return sr;
            }
            else
            {
                sr.Data = _mapper.Map<List<CountryDto>>(await _db.Countries.ToListAsync());
                return sr;
            }
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<CountryDto>> GetFirstOrDefault(Expression<Func<Country, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<CountryDto> sr = new ServiceResponse<CountryDto>();
        try
        {
            var countryFromDb = await _db.Countries.FirstOrDefaultAsync(filter!);
            sr.Data = _mapper.Map<CountryDto>(countryFromDb);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(CountryDto entity)
    {
        try
        {
            _db.Countries.Remove(_mapper.Map<Country>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<CountryDto> entities)
    {
        try
        {
            _db.Countries.RemoveRange(_mapper.Map<IEnumerable<Country>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<CountryDto>> Update(CountryDto entity)
    {
        ServiceResponse<CountryDto> sr = new ServiceResponse<CountryDto>();
        try
        {
            var result = _db.Countries.Update(_mapper.Map<Country>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<CountryDto>(result);
            return sr;

        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
