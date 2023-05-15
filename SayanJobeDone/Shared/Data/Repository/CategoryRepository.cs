using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;

    public CategoryRepository(ApplicationDbContext db)
    {
        this._db = db;
    }

    public Task Add(CategoryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoryDto>> GetAll(Expression<Func<CategoryDto, bool>>? filter = null, Func<IQueryable<CategoryDto>, IOrderedQueryable<CategoryDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> GetFirstOrDefault(Expression<Func<CategoryDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(CategoryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<CategoryDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> Update(CategoryDto entity)
    {
        throw new NotImplementedException();
    }
}
