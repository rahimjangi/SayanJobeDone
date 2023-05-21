using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.SignUpModelService;

public class SignUpModelRepository : ISignUpModelRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public SignUpModelRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(SignUpModelDto entity)
    {
        try
        {
            await _db.SignUpModel.AddAsync(_mapper.Map<SignUpModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<SignUpModelDto>> GetAll(Expression<Func<SignUpModel, bool>>? filter = null, Func<IQueryable<SignUpModel>, IOrderedQueryable<SignUpModel>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<SignUpModelDto>>(await _db.SignUpModel.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<SignUpModelDto> GetFirstOrDefault(Expression<Func<SignUpModel, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<SignUpModelDto>(await _db.SignUpModel.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(SignUpModelDto entity)
    {
        try
        {
            _db.SignUpModel.Remove(_mapper.Map<SignUpModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<SignUpModelDto> entities)
    {
        try
        {
            _db.SignUpModel.RemoveRange(_mapper.Map<IEnumerable<SignUpModel>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<SignUpModelDto> Update(SignUpModelDto entity)
    {
        try
        {
            var result = _db.SignUpModel.Update(_mapper.Map<SignUpModel>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<SignUpModelDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
