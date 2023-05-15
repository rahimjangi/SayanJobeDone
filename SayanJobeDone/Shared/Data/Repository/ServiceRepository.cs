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

    public Task Add(ServiceDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<ServiceDto>> GetAll(Expression<Func<ServiceDto, bool>>? filter = null, Func<IQueryable<ServiceDto>, IOrderedQueryable<ServiceDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceDto> GetFirstOrDefault(Expression<Func<ServiceDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceDto> Update(ServiceDto entity)
    {
        throw new NotImplementedException();
    }
}
