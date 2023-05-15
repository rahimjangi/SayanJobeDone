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

    public Task Add(NationalityDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<NationalityDto>> GetAll(Expression<Func<NationalityDto, bool>>? filter = null, Func<IQueryable<NationalityDto>, IOrderedQueryable<NationalityDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<NationalityDto> GetFirstOrDefault(Expression<Func<NationalityDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(NationalityDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<NationalityDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<NationalityDto> Update(NationalityDto entity)
    {
        throw new NotImplementedException();
    }
}
