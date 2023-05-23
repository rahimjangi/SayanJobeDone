using SayanJobeDone.Shared.Services;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services
{
    public interface IRepository<T, P> where T : class where P : class
    {
        Task Add(T entity);
        Task<ServiceResponse<T>> Update(T entity);
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
        Task<ServiceResponse<List<T>>> GetAll(Expression<Func<P, bool>>? filter = null,
            Func<IQueryable<P>, IOrderedQueryable<P>>? orderby = null,
            string? includeProperties = null);
        Task<ServiceResponse<T>> GetFirstOrDefault(Expression<Func<P, bool>>? filter = null, string? includeProperties = null);
    }
}
