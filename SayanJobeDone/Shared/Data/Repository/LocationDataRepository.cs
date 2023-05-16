using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
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

    public Task Add(LocationDataDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<LocationDataDto>> GetAll(Expression<Func<LocationData, bool>>? filter = null, Func<IQueryable<LocationData>, IOrderedQueryable<LocationData>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<LocationDataDto> GetFirstOrDefault(Expression<Func<LocationData, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LocationDataDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LocationDataDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<LocationDataDto> Update(LocationDataDto entity)
    {
        throw new NotImplementedException();
    }
}
