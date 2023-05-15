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

    public Task Add(EmploymentStatus entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<EmploymentStatus>> GetAll(Expression<Func<EmploymentStatus, bool>>? filter = null, Func<IQueryable<EmploymentStatus>, IOrderedQueryable<EmploymentStatus>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<EmploymentStatus> GetFirstOrDefault(Expression<Func<EmploymentStatus, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(EmploymentStatus entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<EmploymentStatus> entities)
    {
        throw new NotImplementedException();
    }

    public Task<EmploymentStatus> Update(EmploymentStatus entity)
    {
        throw new NotImplementedException();
    }
}
