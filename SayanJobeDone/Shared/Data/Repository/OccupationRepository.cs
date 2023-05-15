using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class OccupationRepository : IOccupationRepository
{
    private readonly ApplicationDbContext _db;

    public OccupationRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(OccupationDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<OccupationDto>> GetAll(Expression<Func<OccupationDto, bool>>? filter = null, Func<IQueryable<OccupationDto>, IOrderedQueryable<OccupationDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<OccupationDto> GetFirstOrDefault(Expression<Func<OccupationDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(OccupationDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<OccupationDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<OccupationDto> Update(OccupationDto entity)
    {
        throw new NotImplementedException();
    }
}
