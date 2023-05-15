using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class RateTypeRepository : IRateTypeRepository
{
    private readonly ApplicationDbContext _db;

    public RateTypeRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(RateTypeDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<RateTypeDto>> GetAll(Expression<Func<RateTypeDto, bool>>? filter = null, Func<IQueryable<RateTypeDto>, IOrderedQueryable<RateTypeDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<RateTypeDto> GetFirstOrDefault(Expression<Func<RateTypeDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(RateTypeDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<RateTypeDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<RateTypeDto> Update(RateTypeDto entity)
    {
        throw new NotImplementedException();
    }
}
