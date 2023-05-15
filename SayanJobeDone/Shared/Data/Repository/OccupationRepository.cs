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

    public Task Add(Occupation entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Occupation>> GetAll(Expression<Func<Occupation, bool>>? filter = null, Func<IQueryable<Occupation>, IOrderedQueryable<Occupation>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Occupation> GetFirstOrDefault(Expression<Func<Occupation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Occupation entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Occupation> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Occupation> Update(Occupation entity)
    {
        throw new NotImplementedException();
    }
}
