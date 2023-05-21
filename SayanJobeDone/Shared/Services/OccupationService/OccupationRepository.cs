using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.OccupationService;

public class OccupationRepository : IOccupationRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public OccupationRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(OccupationDto entity)
    {
        try
        {
            await _db.Occupations.AddAsync(_mapper.Map<Occupation>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<OccupationDto>> GetAll(Expression<Func<Occupation, bool>>? filter = null, Func<IQueryable<Occupation>, IOrderedQueryable<Occupation>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<OccupationDto>>(await _db.Occupations.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<OccupationDto> GetFirstOrDefault(Expression<Func<Occupation, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<OccupationDto>(await _db.Occupations.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(OccupationDto entity)
    {
        try
        {
            _db.Occupations.Remove(_mapper.Map<Occupation>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<OccupationDto> entities)
    {
        try
        {
            _db.Occupations.RemoveRange(_mapper.Map<IEnumerable<Occupation>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<OccupationDto> Update(OccupationDto entity)
    {
        try
        {
            var result = _db.Occupations.Update(_mapper.Map<Occupation>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<OccupationDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
