using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class CityRepository : ICityRepository
{
    private readonly ApplicationDbContext _db;

    public CityRepository(ApplicationDbContext db)
    {
        this._db = db;
    }

    public Task Add(City entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<City>> GetAll(Expression<Func<City, bool>>? filter = null, Func<IQueryable<City>, IOrderedQueryable<City>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<City> GetFirstOrDefault(Expression<Func<City, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(City entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<City> entities)
    {
        throw new NotImplementedException();
    }

    public Task<City> Update(City entity)
    {
        throw new NotImplementedException();
    }
}
