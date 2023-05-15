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

    public void Add(Service entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Service> GetAll(Expression<Func<Service, bool>>? filter = null, Func<IQueryable<Service>, IOrderedQueryable<Service>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Service GetFirstOrDefault(Expression<Func<Service, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Service entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Service> entities)
    {
        throw new NotImplementedException();
    }
}
