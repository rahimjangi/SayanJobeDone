using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.NationalityService;

public class NationalityRepository : INationalityRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public NationalityRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

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

    public async Task<List<NationalityDto>> GetAll(Expression<Func<Nationality, bool>>? filter = null, Func<IQueryable<Nationality>, IOrderedQueryable<Nationality>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<NationalityDto>>(await _db.Nationalities.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<NationalityDto> GetFirstOrDefault(Expression<Func<Nationality, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<NationalityDto>(await _db.Nationalities.FirstOrDefaultAsync(filter!));
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

    public async Task<NationalityDto> Update(NationalityDto entity)
    {
        try
        {
            var result = _db.Nationalities.Update(_mapper.Map<Nationality>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<NationalityDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
