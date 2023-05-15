﻿using SayanJobeDone.Shared.Data.Repository.IRepository;
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

    public Task Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetAll(Expression<Func<Category, bool>>? filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetFirstOrDefault(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Category entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Category> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Category> Update(Category entity)
    {
        throw new NotImplementedException();
    }
}
