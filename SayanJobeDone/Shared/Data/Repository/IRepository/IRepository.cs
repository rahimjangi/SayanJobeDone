using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository.IRepository;

public interface IRepository<T, P> where T : class where P : class
{
    Task Add(T entity);
    Task<T> Update(T entity);
    Task Remove(T entity);
    Task RemoveRange(IEnumerable<T> entities);
    Task<List<T>> GetAll(Expression<Func<P, bool>>? filter = null,
        Func<IQueryable<P>, IOrderedQueryable<P>>? orderby = null,
        string? includeProperties = null);
    Task<T> GetFirstOrDefault(Expression<Func<P, bool>>? filter = null, string? includeProperties = null);
}
