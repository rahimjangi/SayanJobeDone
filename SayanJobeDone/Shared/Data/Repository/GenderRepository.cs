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

    public void Add(Gender entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Gender> GetAll(Expression<Func<Gender, bool>>? filter = null, Func<IQueryable<Gender>, IOrderedQueryable<Gender>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Gender GetFirstOrDefault(Expression<Func<Gender, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Gender entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Gender> entities)
    {
        throw new NotImplementedException();
    }
}
