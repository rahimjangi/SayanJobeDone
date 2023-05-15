using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class RateTypeRepository : IRateTypeRepository
{
    private readonly ApplicationDbContext _db;

    public RateTypeRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(RateType entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<RateType> GetAll(Expression<Func<RateType, bool>>? filter = null, Func<IQueryable<RateType>, IOrderedQueryable<RateType>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public RateType GetFirstOrDefault(Expression<Func<RateType, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(RateType entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<RateType> entities)
    {
        throw new NotImplementedException();
    }
}
