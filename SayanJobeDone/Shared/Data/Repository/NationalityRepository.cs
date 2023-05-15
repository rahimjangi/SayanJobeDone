using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class NationalityRepository : INationalityRepository
{
    private readonly ApplicationDbContext _db;

    public NationalityRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void Add(Nationality entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Nationality> GetAll(Expression<Func<Nationality, bool>>? filter = null, Func<IQueryable<Nationality>, IOrderedQueryable<Nationality>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Nationality GetFirstOrDefault(Expression<Func<Nationality, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Nationality entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Nationality> entities)
    {
        throw new NotImplementedException();
    }
}
