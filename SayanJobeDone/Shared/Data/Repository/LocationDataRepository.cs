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

    public Task Add(LocationData entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<LocationData>> GetAll(Expression<Func<LocationData, bool>>? filter = null, Func<IQueryable<LocationData>, IOrderedQueryable<LocationData>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<LocationData> GetFirstOrDefault(Expression<Func<LocationData, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LocationData entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LocationData> entities)
    {
        throw new NotImplementedException();
    }

    public Task<LocationData> Update(LocationData entity)
    {
        throw new NotImplementedException();
    }
}
