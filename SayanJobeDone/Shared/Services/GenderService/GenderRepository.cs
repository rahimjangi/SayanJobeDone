using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.GenderService;

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

    public async Task<ServiceResponse<List<GenderDto>>> GetAll(Expression<Func<Gender, bool>>? filter = null, Func<IQueryable<Gender>, IOrderedQueryable<Gender>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<GenderDto>> sr = new ServiceResponse<List<GenderDto>>();
        try
        {
            sr.Data = _mapper.Map<List<GenderDto>>(await _db.Genders.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<GenderDto>> GetFirstOrDefault(Expression<Func<Gender, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<GenderDto> sr = new ServiceResponse<GenderDto>();
        try
        {
            sr.Data = _mapper.Map<GenderDto>(await _db.Genders.FirstOrDefaultAsync(filter!));
            return sr;
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

    public async Task<ServiceResponse<GenderDto>> Update(GenderDto entity)
    {
        ServiceResponse<GenderDto> sr = new ServiceResponse<GenderDto>();
        try
        {
            var result = _db.Genders.Update(_mapper.Map<Gender>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<GenderDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
