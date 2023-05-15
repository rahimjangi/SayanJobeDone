using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class EmploymentStatusRepository : IEmploymentStatusRepository
{
    private readonly ApplicationDbContext _db;

    public EmploymentStatusRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(EmploymentStatus entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EmploymentStatus> GetAll(Expression<Func<EmploymentStatus, bool>>? filter = null, Func<IQueryable<EmploymentStatus>, IOrderedQueryable<EmploymentStatus>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public EmploymentStatus GetFirstOrDefault(Expression<Func<EmploymentStatus, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(EmploymentStatus entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<EmploymentStatus> entities)
    {
        throw new NotImplementedException();
    }
}
