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

    public Task Add(PreviousEmployment entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<PreviousEmployment>> GetAll(Expression<Func<PreviousEmployment, bool>>? filter = null, Func<IQueryable<PreviousEmployment>, IOrderedQueryable<PreviousEmployment>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<PreviousEmployment> GetFirstOrDefault(Expression<Func<PreviousEmployment, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(PreviousEmployment entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<PreviousEmployment> entities)
    {
        throw new NotImplementedException();
    }

    public Task<PreviousEmployment> Update(PreviousEmployment entity)
    {
        throw new NotImplementedException();
    }
}
