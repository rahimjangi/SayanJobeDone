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

    public Task Add(RateType entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<RateType>> GetAll(Expression<Func<RateType, bool>>? filter = null, Func<IQueryable<RateType>, IOrderedQueryable<RateType>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<RateType> GetFirstOrDefault(Expression<Func<RateType, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(RateType entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<RateType> entities)
    {
        throw new NotImplementedException();
    }

    public Task<RateType> Update(RateType entity)
    {
        throw new NotImplementedException();
    }
}
