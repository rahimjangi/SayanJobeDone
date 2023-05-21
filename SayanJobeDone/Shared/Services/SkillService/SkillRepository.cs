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

    public async Task<List<SkillDto>> GetAll(Expression<Func<Skill, bool>>? filter = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<SkillDto>>(await _db.Skills.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<SkillDto> GetFirstOrDefault(Expression<Func<Skill, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<SkillDto>(await _db.Skills.FirstOrDefaultAsync(filter!));
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

    public async Task<SkillDto> Update(SkillDto entity)
    {
        try
        {
            var result = _db.Skills.Update(_mapper.Map<Skill>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<SkillDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
