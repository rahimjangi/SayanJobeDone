using SayanJobeDone.Shared.Data.Repository;
using SayanJobeDone.Shared.Data.Repository.IRepository;

namespace SayanJobeDone.Shared.Data;

public class UnitOfWork : IUnitOfWorkRepository
{
    private readonly ApplicationDbContext _db;
    public IAddressRepository Address { get; }
    public ICategoryRepository Category { get; }
    public ICityRepository City { get; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Address = new AddressRepository(_db);

    }
}
