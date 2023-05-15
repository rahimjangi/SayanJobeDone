using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceRepository : IServiceRepository
{
    private readonly ApplicationDbContext _db;

    public ServiceRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(Service entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Service>> GetAll(Expression<Func<Service, bool>>? filter = null, Func<IQueryable<Service>, IOrderedQueryable<Service>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Service> GetFirstOrDefault(Expression<Func<Service, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Service entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Service> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Service> Update(Service entity)
    {
        throw new NotImplementedException();
    }
}
