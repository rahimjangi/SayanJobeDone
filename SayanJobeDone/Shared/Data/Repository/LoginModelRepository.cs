using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class LoginModelRepository : ILoginModelRepository
{
    private readonly ApplicationDbContext _db;

    public LoginModelRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(LoginModel entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<LoginModel> GetAll(Expression<Func<LoginModel, bool>>? filter = null, Func<IQueryable<LoginModel>, IOrderedQueryable<LoginModel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public LoginModel GetFirstOrDefault(Expression<Func<LoginModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(LoginModel entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<LoginModel> entities)
    {
        throw new NotImplementedException();
    }
}
