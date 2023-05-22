using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.LanguageService;

public class LanguageRepository : ILanguageRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public LanguageRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(LanguageDto entity)
    {
        try
        {
            await _db.Languages.AddAsync(_mapper.Map<Language>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<LanguageDto>>> GetAll(Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<LanguageDto>> sr = new ServiceResponse<List<LanguageDto>>();
        try
        {
            sr.Data = _mapper.Map<List<LanguageDto>>(await _db.Languages.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<LanguageDto>> GetFirstOrDefault(Expression<Func<Language, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<LanguageDto> sr = new ServiceResponse<LanguageDto>();
        try
        {
            sr.Data = _mapper.Map<LanguageDto>(await _db.Languages.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(LanguageDto entity)
    {
        try
        {
            _db.Languages.Remove(_mapper.Map<Language>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<LanguageDto> entities)
    {
        try
        {
            _db.Languages.RemoveRange(_mapper.Map<IEnumerable<Language>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<LanguageDto>> Update(LanguageDto entity)
    {
        ServiceResponse<LanguageDto> sr = new ServiceResponse<LanguageDto>();
        try
        {
            var result = _db.Languages.Update(_mapper.Map<Language>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<LanguageDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
