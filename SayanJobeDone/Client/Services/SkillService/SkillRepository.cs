using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.SkillService;

public class SkillRepository : ISkillRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public SkillRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(SkillDto entity)
    {
        try
        {
            await _db.Skills.AddAsync(_mapper.Map<Skill>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<SkillDto>>> GetAll(Expression<Func<Skill, bool>>? filter = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<SkillDto>> sr = new ServiceResponse<List<SkillDto>>();
        try
        {
            sr.Data = _mapper.Map<List<SkillDto>>(await _db.Skills.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<SkillDto>> GetFirstOrDefault(Expression<Func<Skill, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<SkillDto> sr = new ServiceResponse<SkillDto>();
        try
        {
            sr.Data = _mapper.Map<SkillDto>(await _db.Skills.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(SkillDto entity)
    {
        try
        {
            _db.Skills.Remove(_mapper.Map<Skill>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<SkillDto> entities)
    {
        try
        {
            _db.Skills.RemoveRange(_mapper.Map<IEnumerable<Skill>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<SkillDto>> Update(SkillDto entity)
    {
        ServiceResponse<SkillDto> sr = new ServiceResponse<SkillDto>();
        try
        {
            var result = _db.Skills.Update(_mapper.Map<Skill>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<SkillDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
