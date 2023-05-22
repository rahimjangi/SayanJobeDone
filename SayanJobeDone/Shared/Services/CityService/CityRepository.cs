using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.CityService;

public class CityRepository : ICityRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CityRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(CityDto entity)
    {
        try
        {
            var city = _mapper.Map<CityDto, City>(entity);
            var countryFromDb = await _db.Countries.FirstOrDefaultAsync(x => x.Id == entity.CountryId);
            if (countryFromDb != null)
            {
                city.Country = countryFromDb;
                await _db.Cities.AddAsync(city);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Country does not exist");
            }
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<CityDto>>> GetAll(Expression<Func<City, bool>>? filter = null, Func<IQueryable<City>, IOrderedQueryable<City>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<CityDto>> sr = new ServiceResponse<List<CityDto>>();
        try
        {


            if (includeProperties != null)
            {
                var valueList = await _db.Cities.Include(includeProperties).ToListAsync();
                var resultInclude = _mapper.Map<List<CityDto>>(valueList);
                sr.Data = resultInclude;
                return sr;
            }
            var result = _mapper.Map<List<CityDto>>(await _db.Cities.ToListAsync());
            sr.Data = result;
            return sr;

        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task<ServiceResponse<CityDto>> GetFirstOrDefault(Expression<Func<City, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<CityDto> sr = new ServiceResponse<CityDto>();
        try
        {
            if (includeProperties != null & filter != null)
            {
                var resultInclude = await _db.Cities.Include(includeProperties!).FirstOrDefaultAsync(filter!);
                if (resultInclude != null)
                {
                    sr.Data = _mapper.Map<CityDto>(resultInclude);
                }
            }
            else
            {

                var result = await _db.Cities.FirstOrDefaultAsync(filter!);
                sr.Data = _mapper.Map<CityDto>(result);
            }
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
        throw new NotImplementedException();
    }

    public async Task Remove(CityDto entity)
    {
        try
        {
            _db.Cities.Remove(_mapper.Map<City>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task RemoveRange(IEnumerable<CityDto> entities)
    {
        try
        {
            _db.Cities.RemoveRange(_mapper.Map<City>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task<ServiceResponse<CityDto>> Update(CityDto entity)
    {
        ServiceResponse<CityDto> sr = new ServiceResponse<CityDto>();
        try
        {
            var updatedObj = _db.Cities.Update(_mapper.Map<City>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<CityDto>(updatedObj.Entity);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }
}
