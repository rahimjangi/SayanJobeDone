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

    public Task Add(Address entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Address>> GetAll(Expression<Func<Address, bool>>? filter = null, Func<IQueryable<Address>, IOrderedQueryable<Address>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Address> GetFirstOrDefault(Expression<Func<Address, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Address entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Address> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Address> Update(Address entity)
    {
        throw new NotImplementedException();
    }
}
