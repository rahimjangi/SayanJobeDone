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

    public void Add(MobilePhone entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MobilePhone> GetAll(Expression<Func<MobilePhone, bool>>? filter = null, Func<IQueryable<MobilePhone>, IOrderedQueryable<MobilePhone>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public MobilePhone GetFirstOrDefault(Expression<Func<MobilePhone, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(MobilePhone entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<MobilePhone> entities)
    {
        throw new NotImplementedException();
    }
}
