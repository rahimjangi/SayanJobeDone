using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class LocationDataRepository : ILocationDataRepository
{
    private readonly ApplicationDbContext _db;

    public LocationDataRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(LocationData entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<LocationData> GetAll(Expression<Func<LocationData, bool>>? filter = null, Func<IQueryable<LocationData>, IOrderedQueryable<LocationData>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public LocationData GetFirstOrDefault(Expression<Func<LocationData, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(LocationData entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<LocationData> entities)
    {
        throw new NotImplementedException();
    }
}
