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

    public Task Add(Language entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Language>> GetAll(Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Language> GetFirstOrDefault(Expression<Func<Language, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Language entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Language> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Language> Update(Language entity)
    {
        throw new NotImplementedException();
    }
}
