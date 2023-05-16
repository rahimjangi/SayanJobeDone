using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class LoginModelRepository : ILoginModelRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public LoginModelRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(LoginModelDto entity)
    {
        try
        {
            await _db.LoginModel.AddAsync(_mapper.Map<LoginModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<LoginModelDto>> GetAll(Expression<Func<LoginModel, bool>>? filter = null, Func<IQueryable<LoginModel>, IOrderedQueryable<LoginModel>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<LoginModelDto>>(await _db.LoginModel.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<LoginModelDto> GetFirstOrDefault(Expression<Func<LoginModel, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<LoginModelDto>(await _db.LoginModel.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(LoginModelDto entity)
    {
        try
        {
            _db.LoginModel.Remove(_mapper.Map<LoginModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<LoginModelDto> entities)
    {
        try
        {
            _db.LoginModel.RemoveRange(_mapper.Map<IEnumerable<LoginModel>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<LoginModelDto> Update(LoginModelDto entity)
    {
        try
        {
            var result = _db.LoginModel.Update(_mapper.Map<LoginModel>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<LoginModelDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
