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

    public void Add(ServiceReceiver entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ServiceReceiver> GetAll(Expression<Func<ServiceReceiver, bool>>? filter = null, Func<IQueryable<ServiceReceiver>, IOrderedQueryable<ServiceReceiver>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public ServiceReceiver GetFirstOrDefault(Expression<Func<ServiceReceiver, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(ServiceReceiver entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<ServiceReceiver> entities)
    {
        throw new NotImplementedException();
    }
}
