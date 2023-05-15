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

    public void Add(Skill entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Skill> GetAll(Expression<Func<Skill, bool>>? filter = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Skill GetFirstOrDefault(Expression<Func<Skill, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Skill entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Skill> entities)
    {
        throw new NotImplementedException();
    }
}
