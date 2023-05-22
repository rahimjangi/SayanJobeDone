using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.PreviousEmploymentService;

public class PreviousEmploymentRepository : IPreviousEmploymentRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public PreviousEmploymentRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(PreviousEmploymentDto entity)
    {
        try
        {
            await _db.PreviousEmployments.AddAsync(_mapper.Map<PreviousEmployment>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<PreviousEmploymentDto>>> GetAll(Expression<Func<PreviousEmployment, bool>>? filter = null, Func<IQueryable<PreviousEmployment>, IOrderedQueryable<PreviousEmployment>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<PreviousEmploymentDto>> sr = new ServiceResponse<List<PreviousEmploymentDto>>();
        try
        {
            sr.Data = _mapper.Map<List<PreviousEmploymentDto>>(await _db.PreviousEmployments.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<PreviousEmploymentDto>> GetFirstOrDefault(Expression<Func<PreviousEmployment, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<PreviousEmploymentDto> sr = new ServiceResponse<PreviousEmploymentDto>();
        try
        {
            sr.Data = _mapper.Map<PreviousEmploymentDto>(await _db.PreviousEmployments.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(PreviousEmploymentDto entity)
    {
        try
        {
            _db.PreviousEmployments.Remove(_mapper.Map<PreviousEmployment>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<PreviousEmploymentDto> entities)
    {
        try
        {
            _db.PreviousEmployments.RemoveRange(_mapper.Map<IEnumerable<PreviousEmployment>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<PreviousEmploymentDto>> Update(PreviousEmploymentDto entity)
    {
        ServiceResponse<PreviousEmploymentDto> sr = new ServiceResponse<PreviousEmploymentDto>();
        try
        {
            var result = _db.PreviousEmployments.Update(_mapper.Map<PreviousEmployment>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<PreviousEmploymentDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
