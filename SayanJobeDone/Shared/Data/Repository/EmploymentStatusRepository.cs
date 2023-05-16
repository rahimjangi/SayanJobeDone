using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class EmploymentStatusRepository : IEmploymentStatusRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public EmploymentStatusRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(EmploymentStatusDto entity)
    {
        try
        {
            await _db.EmploymentStatuses.AddAsync(_mapper.Map<EmploymentStatus>(entity));
            await _db.AddRangeAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<EmploymentStatusDto>> GetAll(Expression<Func<EmploymentStatus, bool>>? filter = null, Func<IQueryable<EmploymentStatus>, IOrderedQueryable<EmploymentStatus>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<EmploymentStatusDto>>(await _db.EmploymentStatuses.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<EmploymentStatusDto> GetFirstOrDefault(Expression<Func<EmploymentStatus, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<EmploymentStatusDto>(await _db.EmploymentStatuses.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(EmploymentStatusDto entity)
    {
        try
        {
            _db.EmploymentStatuses.Remove(_mapper.Map<EmploymentStatus>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<EmploymentStatusDto> entities)
    {
        try
        {
            _db.EmploymentStatuses.RemoveRange(_mapper.Map<IEnumerable<EmploymentStatus>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<EmploymentStatusDto> Update(EmploymentStatusDto entity)
    {
        try
        {
            var result = _db.EmploymentStatuses.Update(_mapper.Map<EmploymentStatus>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<EmploymentStatusDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
