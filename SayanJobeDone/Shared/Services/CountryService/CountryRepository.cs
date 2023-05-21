using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.CountryService;
public class CountryRepository : ICountryRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CountryRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

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

    public async Task<List<CountryDto>> GetAll(Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            if (filter != null)
            {
                var countryFilter = _mapper.Map<Expression<Func<Country, bool>>, Expression<Func<Country, bool>>>(filter);
                var listOfCountry = await _db.Countries.Where(countryFilter).ToListAsync();
                var result = _mapper.Map<List<CountryDto>>(listOfCountry);
                return result;
            }
            else
            {
                return _mapper.Map<List<CountryDto>>(await _db.Countries.ToListAsync());
            }
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<CountryDto> GetFirstOrDefault(Expression<Func<Country, bool>>? filter = null, string? includeProperties = null)
    {

        try
        {
            var countryFromDb = await _db.Countries.FirstOrDefaultAsync(filter!);
            return _mapper.Map<CountryDto>(countryFromDb);
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

    public async Task<CountryDto> Update(CountryDto entity)
    {
        try
        {
            var result = _db.Countries.Update(_mapper.Map<Country>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<CountryDto>(result);

        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
