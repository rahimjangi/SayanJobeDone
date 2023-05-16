using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
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

    public Task Add(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<EducationLevelDto>> GetAll(Expression<Func<EducationLevel, bool>>? filter = null, Func<IQueryable<EducationLevel>, IOrderedQueryable<EducationLevel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<EducationLevelDto> GetFirstOrDefault(Expression<Func<EducationLevel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<EducationLevelDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<EducationLevelDto> Update(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }
}
