using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class MobilePhoneRepository : IMobilePhoneRepository
{
    private readonly ApplicationDbContext _db;

    public MobilePhoneRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(MobilePhone entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<MobilePhone>> GetAll(Expression<Func<MobilePhone, bool>>? filter = null, Func<IQueryable<MobilePhone>, IOrderedQueryable<MobilePhone>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<MobilePhone> GetFirstOrDefault(Expression<Func<MobilePhone, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(MobilePhone entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<MobilePhone> entities)
    {
        throw new NotImplementedException();
    }

    public Task<MobilePhone> Update(MobilePhone entity)
    {
        throw new NotImplementedException();
    }
}
