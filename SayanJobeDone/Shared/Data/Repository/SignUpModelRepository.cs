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

    public Task Add(SignUpModel entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<SignUpModel>> GetAll(Expression<Func<SignUpModel, bool>>? filter = null, Func<IQueryable<SignUpModel>, IOrderedQueryable<SignUpModel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<SignUpModel> GetFirstOrDefault(Expression<Func<SignUpModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(SignUpModel entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<SignUpModel> entities)
    {
        throw new NotImplementedException();
    }

    public Task<SignUpModel> Update(SignUpModel entity)
    {
        throw new NotImplementedException();
    }
}
