using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(UserDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserDto>> GetAll(Expression<Func<User, bool>>? filter = null, Func<IQueryable<User>, IOrderedQueryable<User>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> GetFirstOrDefault(Expression<Func<User, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(UserDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<UserDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> Update(UserDto entity)
    {
        throw new NotImplementedException();
    }
}
