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

    public Task Add(Country entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Country>> GetAll(Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Country> GetFirstOrDefault(Expression<Func<Country, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Country entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Country> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Country> Update(Country entity)
    {
        throw new NotImplementedException();
    }
}
