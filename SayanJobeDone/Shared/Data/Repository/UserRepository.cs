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

    public void Add(User entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAll(Expression<Func<User, bool>>? filter = null, Func<IQueryable<User>, IOrderedQueryable<User>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public User GetFirstOrDefault(Expression<Func<User, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(User entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<User> entities)
    {
        throw new NotImplementedException();
    }
}
