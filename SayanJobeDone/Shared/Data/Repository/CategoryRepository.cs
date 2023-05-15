using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;

    public CategoryRepository(ApplicationDbContext db)
    {
        this._db = db;
    }
    public void Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Category> GetAll(Expression<Func<Category, bool>>? filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Category GetFirstOrDefault(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Category entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Category> entities)
    {
        throw new NotImplementedException();
    }
}
