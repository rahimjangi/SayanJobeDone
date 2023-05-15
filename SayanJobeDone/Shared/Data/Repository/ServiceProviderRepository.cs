﻿using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly ApplicationDbContext _db;

    public ServiceProviderRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(ServiceProvidersDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<ServiceProvidersDto>> GetAll(Expression<Func<ServiceProvidersDto, bool>>? filter = null, Func<IQueryable<ServiceProvidersDto>, IOrderedQueryable<ServiceProvidersDto>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceProvidersDto> GetFirstOrDefault(Expression<Func<ServiceProvidersDto, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceProvidersDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceProvidersDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceProvidersDto> Update(ServiceProvidersDto entity)
    {
        throw new NotImplementedException();
    }
}
