using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class RateTypeRepository : IRateTypeRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public RateTypeRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

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

    public async Task<List<RateTypeDto>> GetAll(Expression<Func<RateType, bool>>? filter = null, Func<IQueryable<RateType>, IOrderedQueryable<RateType>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<RateTypeDto>>(await _db.RateTypes.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<RateTypeDto> GetFirstOrDefault(Expression<Func<RateType, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<RateTypeDto>(await _db.RateTypes.FirstOrDefaultAsync(filter!));
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

    public async Task<RateTypeDto> Update(RateTypeDto entity)
    {
        try
        {
            var result = _db.RateTypes.Update(_mapper.Map<RateType>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<RateTypeDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
