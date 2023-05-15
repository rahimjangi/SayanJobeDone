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
    public void Add(City entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<City> GetAll(Expression<Func<City, bool>>? filter = null, Func<IQueryable<City>, IOrderedQueryable<City>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public City GetFirstOrDefault(Expression<Func<City, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(City entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<City> entities)
    {
        throw new NotImplementedException();
    }
}
