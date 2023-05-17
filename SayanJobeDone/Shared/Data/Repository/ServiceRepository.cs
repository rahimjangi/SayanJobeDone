﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class ServiceRepository : IServiceRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public ServiceRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(ServiceDto entity)
    {
        try
        {
            await _db.Services.AddAsync(_mapper.Map<Service>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<ServiceDto>> GetAll(Expression<Func<Service, bool>>? filter = null, Func<IQueryable<Service>, IOrderedQueryable<Service>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<ServiceDto>>(await _db.Services.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceDto> GetFirstOrDefault(Expression<Func<Service, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<ServiceDto>(await _db.Services.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(ServiceDto entity)
    {
        try
        {
            _db.Services.Remove(_mapper.Map<Service>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<ServiceDto> entities)
    {
        try
        {
            _db.Services.RemoveRange(_mapper.Map<IEnumerable<Service>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceDto> Update(ServiceDto entity)
    {
        try
        {
            var result = _db.Services.Update(_mapper.Map<Service>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<ServiceDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
