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

    public Task Add(LoginModel entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<LoginModel>> GetAll(Expression<Func<LoginModel, bool>>? filter = null, Func<IQueryable<LoginModel>, IOrderedQueryable<LoginModel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<LoginModel> GetFirstOrDefault(Expression<Func<LoginModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LoginModel entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LoginModel> entities)
    {
        throw new NotImplementedException();
    }

    public Task<LoginModel> Update(LoginModel entity)
    {
        throw new NotImplementedException();
    }
}
