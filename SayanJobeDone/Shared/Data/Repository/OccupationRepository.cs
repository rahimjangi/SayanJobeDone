using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class OccupationRepository : IOccupationRepository
{
    private readonly ApplicationDbContext _db;

    public OccupationRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(Occupation entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Occupation> GetAll(Expression<Func<Occupation, bool>>? filter = null, Func<IQueryable<Occupation>, IOrderedQueryable<Occupation>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Occupation GetFirstOrDefault(Expression<Func<Occupation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Occupation entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Occupation> entities)
    {
        throw new NotImplementedException();
    }
}
