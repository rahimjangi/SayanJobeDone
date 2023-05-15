using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;
public class CountryRepository : ICountryRepository
{
    private readonly ApplicationDbContext _db;

    public CountryRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(Country entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Country> GetAll(Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Country GetFirstOrDefault(Expression<Func<Country, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Country entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Country> entities)
    {
        throw new NotImplementedException();
    }
}
