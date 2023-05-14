using SayanJobeDone.Shared.Data.Repository.IRepository;

namespace SayanJobeDone.Shared.Data;

public interface IUnitOfWorkRepository
{
    IAddressRepository Address { get; }
    ICategoryRepository Category { get; }
    ICityRepository City { get; }
}
