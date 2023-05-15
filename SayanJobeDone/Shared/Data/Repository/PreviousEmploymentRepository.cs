using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class PreviousEmploymentRepository : IPreviousEmploymentRepository
{
    private readonly ApplicationDbContext _db;

    public PreviousEmploymentRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(PreviousEmployment entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PreviousEmployment> GetAll(Expression<Func<PreviousEmployment, bool>>? filter = null, Func<IQueryable<PreviousEmployment>, IOrderedQueryable<PreviousEmployment>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public PreviousEmployment GetFirstOrDefault(Expression<Func<PreviousEmployment, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(PreviousEmployment entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<PreviousEmployment> entities)
    {
        throw new NotImplementedException();
    }
}
