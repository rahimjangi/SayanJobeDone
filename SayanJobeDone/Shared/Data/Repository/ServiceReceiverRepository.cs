using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceReceiverRepository : IServiceReceiverRepository
{
    private readonly ApplicationDbContext _db;

    public ServiceReceiverRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(ServiceReceiver entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<ServiceReceiver>> GetAll(Expression<Func<ServiceReceiver, bool>>? filter = null, Func<IQueryable<ServiceReceiver>, IOrderedQueryable<ServiceReceiver>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceReceiver> GetFirstOrDefault(Expression<Func<ServiceReceiver, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceReceiver entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceReceiver> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceReceiver> Update(ServiceReceiver entity)
    {
        throw new NotImplementedException();
    }
}
