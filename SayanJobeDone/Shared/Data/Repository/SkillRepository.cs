using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class SkillRepository : ISkillRepository
{
    private readonly ApplicationDbContext _db;

    public SkillRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(Skill entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Skill>> GetAll(Expression<Func<Skill, bool>>? filter = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> GetFirstOrDefault(Expression<Func<Skill, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Skill entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Skill> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> Update(Skill entity)
    {
        throw new NotImplementedException();
    }
}
