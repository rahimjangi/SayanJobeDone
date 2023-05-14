using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _db;

    public AddressRepository(ApplicationDbContext db)
    {
        this._db = db;
    }


    public void Add(Address entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Address> GetAll(Expression<Func<Address, bool>>? filter = null, Func<IQueryable<Address>, IOrderedQueryable<Address>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Address GetFirstOrDefault(Expression<Func<Address, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Address entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Address> entities)
    {
        throw new NotImplementedException();
    }
}
