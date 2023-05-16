using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class GenderRepository : IGenderRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public GenderRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(GenderDto entity)
    {
        try
        {
            await _db.Genders.AddAsync(_mapper.Map<Gender>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<GenderDto>> GetAll(Expression<Func<Gender, bool>>? filter = null, Func<IQueryable<Gender>, IOrderedQueryable<Gender>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<GenderDto>>(await _db.Genders.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<GenderDto> GetFirstOrDefault(Expression<Func<Gender, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<GenderDto>(await _db.Genders.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(GenderDto entity)
    {
        try
        {
            _db.Genders.Remove(_mapper.Map<Gender>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<GenderDto> entities)
    {
        try
        {
            _db.Genders.RemoveRange(_mapper.Map<IEnumerable<Gender>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<GenderDto> Update(GenderDto entity)
    {
        try
        {
            var result = _db.Genders.Update(_mapper.Map<Gender>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<GenderDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
