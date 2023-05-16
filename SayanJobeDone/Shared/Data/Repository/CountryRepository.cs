using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;
public class CountryRepository : ICountryRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CountryRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public Task Add(CountryDto entity)
    {
        throw new NotImplementedException();
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
            var countryFromDb = await _db.Countries.FirstOrDefaultAsync(filter);
            return _mapper.Map<CountryDto>(countryFromDb);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public Task Remove(CountryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<CountryDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<CountryDto> Update(CountryDto entity)
    {
        throw new NotImplementedException();
    }
}
