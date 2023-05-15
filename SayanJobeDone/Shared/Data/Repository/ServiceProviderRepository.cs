using SayanJobeDone.Shared.Data.Repository.IRepository;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly ApplicationDbContext _db;

    public ServiceProviderRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(ServiceProviderRepository entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ServiceProviderRepository> GetAll(Expression<Func<ServiceProviderRepository, bool>>? filter = null, Func<IQueryable<ServiceProviderRepository>, IOrderedQueryable<ServiceProviderRepository>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public ServiceProviderRepository GetFirstOrDefault(Expression<Func<ServiceProviderRepository, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }


    public void Remove(ServiceProviderRepository entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<ServiceProviderRepository> entities)
    {
        throw new NotImplementedException();
    }
}
