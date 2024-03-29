﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.MobilePhoneService;

public class MobilePhoneRepository : IMobilePhoneRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public MobilePhoneRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(MobilePhoneDto entity)
    {
        try
        {
            await _db.MobilePhones.AddAsync(_mapper.Map<MobilePhone>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task<ServiceResponse<List<MobilePhoneDto>>> GetAll(Expression<Func<MobilePhone, bool>>? filter = null, Func<IQueryable<MobilePhone>, IOrderedQueryable<MobilePhone>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<MobilePhoneDto>> sr = new ServiceResponse<List<MobilePhoneDto>>();
        try
        {
            sr.Data = _mapper.Map<List<MobilePhoneDto>>(await _db.MobilePhones.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<MobilePhoneDto>> GetFirstOrDefault(Expression<Func<MobilePhone, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<MobilePhoneDto> sr = new ServiceResponse<MobilePhoneDto>();
        try
        {
            sr.Data = _mapper.Map<MobilePhoneDto>(await _db.MobilePhones.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(MobilePhoneDto entity)
    {
        try
        {
            _db.MobilePhones.Remove(_mapper.Map<MobilePhone>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<MobilePhoneDto> entities)
    {
        try
        {
            _db.MobilePhones.RemoveRange(_mapper.Map<IEnumerable<MobilePhone>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<MobilePhoneDto>> Update(MobilePhoneDto entity)
    {
        ServiceResponse<MobilePhoneDto> sr = new ServiceResponse<MobilePhoneDto>();
        try
        {
            var result = _db.MobilePhones.Update(_mapper.Map<MobilePhone>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<MobilePhoneDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
