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

    public Task Add(EducationLevelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<EducationLevelDto>> GetAll(Expression<Func<EducationLevelDto, bool>>? filter = null, Func<IQueryable<EducationLevelDto>, IOrderedQueryable<EducationLevelDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<EducationLevelDto> GetFirstOrDefault(Expression<Func<EducationLevelDto, bool>>? filter = null, string? includeProperties = null)
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
