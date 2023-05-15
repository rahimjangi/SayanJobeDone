using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class EducationLevelRepository : IEducationLevelRepository
{
    private readonly ApplicationDbContext _db;

    public EducationLevelRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(EducationLevel entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<EducationLevel>> GetAll(Expression<Func<EducationLevel, bool>>? filter = null, Func<IQueryable<EducationLevel>, IOrderedQueryable<EducationLevel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<EducationLevel> GetFirstOrDefault(Expression<Func<EducationLevel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(EducationLevel entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<EducationLevel> entities)
    {
        throw new NotImplementedException();
    }

    public Task<EducationLevel> Update(EducationLevel entity)
    {
        throw new NotImplementedException();
    }
}
