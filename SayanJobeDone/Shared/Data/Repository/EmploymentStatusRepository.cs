using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class EmploymentStatusRepository : IEmploymentStatusRepository
{
    private readonly ApplicationDbContext _db;

    public EmploymentStatusRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(EmploymentStatusDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<EmploymentStatusDto>> GetAll(Expression<Func<EmploymentStatusDto, bool>>? filter = null, Func<IQueryable<EmploymentStatusDto>, IOrderedQueryable<EmploymentStatusDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<EmploymentStatusDto> GetFirstOrDefault(Expression<Func<EmploymentStatusDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(EmploymentStatusDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<EmploymentStatusDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<EmploymentStatusDto> Update(EmploymentStatusDto entity)
    {
        throw new NotImplementedException();
    }
}
