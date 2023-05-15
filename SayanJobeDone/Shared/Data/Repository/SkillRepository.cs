using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class SkillRepository : ISkillRepository
{
    private readonly ApplicationDbContext _db;

    public SkillRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(SkillDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<SkillDto>> GetAll(Expression<Func<SkillDto, bool>>? filter = null, Func<IQueryable<SkillDto>, IOrderedQueryable<SkillDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<SkillDto> GetFirstOrDefault(Expression<Func<SkillDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(SkillDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<SkillDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<SkillDto> Update(SkillDto entity)
    {
        throw new NotImplementedException();
    }
}
