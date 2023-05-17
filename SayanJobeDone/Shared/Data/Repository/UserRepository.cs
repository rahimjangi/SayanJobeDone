using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public UserRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(UserDto entity)
    {
        try
        {
            await _db.Users.AddAsync(_mapper.Map<User>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<UserDto>> GetAll(Expression<Func<User, bool>>? filter = null, Func<IQueryable<User>, IOrderedQueryable<User>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<UserDto>>(await _db.Users.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<UserDto> GetFirstOrDefault(Expression<Func<User, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<UserDto>(await _db.Users.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(UserDto entity)
    {
        try
        {
            _db.Users.Remove(_mapper.Map<User>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<UserDto> entities)
    {
        try
        {
            _db.Users.RemoveRange(_mapper.Map<IEnumerable<User>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<UserDto> Update(UserDto entity)
    {
        try
        {
            var result = _db.Users.Update(_mapper.Map<User>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<UserDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
