using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
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

    public Task Add(LanguageDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<LanguageDto>> GetAll(Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<LanguageDto> GetFirstOrDefault(Expression<Func<Language, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LanguageDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LanguageDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<LanguageDto> Update(LanguageDto entity)
    {
        throw new NotImplementedException();
    }
}
