﻿using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository.IRepository;

public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null,
        string? includeProperties = null);
    T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
}
