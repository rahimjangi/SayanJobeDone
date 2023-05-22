using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.EducationLevelService;

public class EducationLevelRepository : IEducationLevelRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public EducationLevelRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(EducationLevelDto entity)
    {
        try
        {
            await _db.EducationLevels.AddAsync(_mapper.Map<EducationLevel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<EducationLevelDto>>> GetAll(Expression<Func<EducationLevel, bool>>? filter = null, Func<IQueryable<EducationLevel>, IOrderedQueryable<EducationLevel>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<EducationLevelDto>> sr = new ServiceResponse<List<EducationLevelDto>>();
        try
        {
            var result = _mapper.Map<List<EducationLevelDto>>(await _db.EducationLevels.ToListAsync());
            await _db.SaveChangesAsync();
            sr.Data = result;
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<EducationLevelDto>> GetFirstOrDefault(Expression<Func<EducationLevel, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<EducationLevelDto> sr = new ServiceResponse<EducationLevelDto>();
        try
        {
            sr.Data = _mapper.Map<EducationLevelDto>(await _db.EducationLevels.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(EducationLevelDto entity)
    {
        try
        {
            _db.EducationLevels.Remove(_mapper.Map<EducationLevel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<EducationLevelDto> entities)
    {
        try
        {
            _db.EducationLevels.RemoveRange(_mapper.Map<EducationLevel>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<EducationLevelDto>> Update(EducationLevelDto entity)
    {
        ServiceResponse<EducationLevelDto> sr = new ServiceResponse<EducationLevelDto>();
        try
        {
            var result = _mapper.Map<EducationLevelDto>(_db.EducationLevels.Update(_mapper.Map<EducationLevel>(entity)));
            await _db.SaveChangesAsync();
            sr.Data = result;
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
