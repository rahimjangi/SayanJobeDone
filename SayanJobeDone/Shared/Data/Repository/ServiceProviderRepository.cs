using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly ApplicationDbContext _db;

    public ServiceProviderRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(ServiceProviders entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<ServiceProviders>> GetAll(Expression<Func<ServiceProviders, bool>>? filter = null, Func<IQueryable<ServiceProviders>, IOrderedQueryable<ServiceProviders>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceProviders> GetFirstOrDefault(Expression<Func<ServiceProviders, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceProviders entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceProviders> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceProviders> Update(ServiceProviders entity)
    {
        throw new NotImplementedException();
    }
}
