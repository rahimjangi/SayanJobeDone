using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class GenderRepository : IGenderRepository
{
    private readonly ApplicationDbContext _db;

    public GenderRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(Gender entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Gender>> GetAll(Expression<Func<Gender, bool>>? filter = null, Func<IQueryable<Gender>, IOrderedQueryable<Gender>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Gender> GetFirstOrDefault(Expression<Func<Gender, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Gender entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Gender> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Gender> Update(Gender entity)
    {
        throw new NotImplementedException();
    }
}
