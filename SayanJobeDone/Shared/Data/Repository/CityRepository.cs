﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class CityRepository : ICityRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public CityRepository(ApplicationDbContext db, Mapper mapper)
    {
        this._db = db;
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

    public async Task<List<CityDto>> GetAll(Expression<Func<CityDto, bool>>? filter = null, Func<IQueryable<CityDto>, IOrderedQueryable<CityDto>>? orderby = null, string? includeProperties = null)
    {
        try
        {


            if (includeProperties != null)
            {
                var valueList = await _db.Cities.Include(includeProperties).ToListAsync();
                return _mapper.Map<List<CityDto>>(valueList);
            }
            return _mapper.Map<List<CityDto>>(await _db.Cities.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task<CityDto> GetFirstOrDefault(Expression<Func<CityDto, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            if (includeProperties != null & filter != null)
            {
                var resultInclude = await _db.Cities.Include(includeProperties!).FirstOrDefaultAsync(filter!);
                if (resultInclude != null) return resultInclude;
            }
            else
            {

                var result = await _db.Cities.FirstOrDefaultAsync(filter!);
                return result!;
            }
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
            _db.Cities.Remove(entity);
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
            _db.Cities.RemoveRange(entities);
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task<CityDto> Update(CityDto entity)
    {
        try
        {
            var updatedObj = _db.Cities.Update(entity);
            await _db.SaveChangesAsync();
            return updatedObj.Entity;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }
}
