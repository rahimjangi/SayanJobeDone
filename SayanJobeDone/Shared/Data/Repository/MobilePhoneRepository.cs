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

    public Task Add(MobilePhoneDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<MobilePhoneDto>> GetAll(Expression<Func<MobilePhoneDto, bool>>? filter = null, Func<IQueryable<MobilePhoneDto>, IOrderedQueryable<MobilePhoneDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<MobilePhoneDto> GetFirstOrDefault(Expression<Func<MobilePhoneDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(MobilePhoneDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<MobilePhoneDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<MobilePhoneDto> Update(MobilePhoneDto entity)
    {
        throw new NotImplementedException();
    }
}
