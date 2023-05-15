using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class PreviousEmploymentRepository : IPreviousEmploymentRepository
{
    private readonly ApplicationDbContext _db;

    public PreviousEmploymentRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(PreviousEmploymentDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<PreviousEmploymentDto>> GetAll(Expression<Func<PreviousEmploymentDto, bool>>? filter = null, Func<IQueryable<PreviousEmploymentDto>, IOrderedQueryable<PreviousEmploymentDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<PreviousEmploymentDto> GetFirstOrDefault(Expression<Func<PreviousEmploymentDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(PreviousEmploymentDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<PreviousEmploymentDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<PreviousEmploymentDto> Update(PreviousEmploymentDto entity)
    {
        throw new NotImplementedException();
    }
}
