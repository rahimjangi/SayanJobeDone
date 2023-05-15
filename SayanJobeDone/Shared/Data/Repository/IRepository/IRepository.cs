using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository.IRepository;

public interface IRepository<T> where T : class
{
    Task Add(T entity);
    Task<T> Update(T entity);
    Task Remove(T entity);
    Task RemoveRange(IEnumerable<T> entities);
    Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null,
        string? includeProperties = null);
    Task<T> GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
}
