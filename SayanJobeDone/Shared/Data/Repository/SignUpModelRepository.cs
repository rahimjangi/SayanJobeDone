using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class SignUpModelRepository : ISignUpModelRepository
{
    private readonly ApplicationDbContext _db;

    public SignUpModelRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(SignUpModel entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SignUpModel> GetAll(Expression<Func<SignUpModel, bool>>? filter = null, Func<IQueryable<SignUpModel>, IOrderedQueryable<SignUpModel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public SignUpModel GetFirstOrDefault(Expression<Func<SignUpModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(SignUpModel entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<SignUpModel> entities)
    {
        throw new NotImplementedException();
    }
}
