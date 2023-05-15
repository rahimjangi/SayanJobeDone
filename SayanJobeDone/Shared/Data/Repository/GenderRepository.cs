using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class GenderRepository : IGenderRepository
{
    private readonly ApplicationDbContext _db;

    public GenderRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(GenderDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<GenderDto>> GetAll(Expression<Func<GenderDto, bool>>? filter = null, Func<IQueryable<GenderDto>, IOrderedQueryable<GenderDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<GenderDto> GetFirstOrDefault(Expression<Func<GenderDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(GenderDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<GenderDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<GenderDto> Update(GenderDto entity)
    {
        throw new NotImplementedException();
    }
}
