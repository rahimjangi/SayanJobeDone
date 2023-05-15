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

    public Task Add(CountryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<CountryDto>> GetAll(Expression<Func<CountryDto, bool>>? filter = null, Func<IQueryable<CountryDto>, IOrderedQueryable<CountryDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<CountryDto> GetFirstOrDefault(Expression<Func<CountryDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(CountryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<CountryDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<CountryDto> Update(CountryDto entity)
    {
        throw new NotImplementedException();
    }
}
