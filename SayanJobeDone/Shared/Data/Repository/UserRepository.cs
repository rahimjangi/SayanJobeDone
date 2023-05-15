using SayanJobeDone.Shared.Data.Repository.IRepository;
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

    public Task Add(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetAll(Expression<Func<User, bool>>? filter = null, Func<IQueryable<User>, IOrderedQueryable<User>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetFirstOrDefault(Expression<Func<User, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(User entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<User> entities)
    {
        throw new NotImplementedException();
    }

    public Task<User> Update(User entity)
    {
        throw new NotImplementedException();
    }
}
