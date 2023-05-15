using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class LanguageRepository : ILanguageRepository
{
    private readonly ApplicationDbContext _db;

    public LanguageRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(Language entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Language> GetAll(Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Language GetFirstOrDefault(Expression<Func<Language, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Language entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Language> entities)
    {
        throw new NotImplementedException();
    }
}
