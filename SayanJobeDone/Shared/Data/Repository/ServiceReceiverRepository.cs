using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceReceiverRepository : IServiceReceiverRepository
{
    private readonly ApplicationDbContext _db;

    public ServiceReceiverRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(ServiceReceiverDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<ServiceReceiverDto>> GetAll(Expression<Func<ServiceReceiverDto, bool>>? filter = null, Func<IQueryable<ServiceReceiverDto>, IOrderedQueryable<ServiceReceiverDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceReceiverDto> GetFirstOrDefault(Expression<Func<ServiceReceiverDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceReceiverDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceReceiverDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceReceiverDto> Update(ServiceReceiverDto entity)
    {
        throw new NotImplementedException();
    }
}
