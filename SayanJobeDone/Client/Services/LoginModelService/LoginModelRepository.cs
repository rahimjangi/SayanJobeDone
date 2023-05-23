using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.LoginModelService;

public class LoginModelRepository : ILoginModelRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public LoginModelRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(LoginModelDto entity)
    {
        try
        {
            await _db.LoginModel.AddAsync(_mapper.Map<LoginModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<LoginModelDto>>> GetAll(Expression<Func<LoginModel, bool>>? filter = null, Func<IQueryable<LoginModel>, IOrderedQueryable<LoginModel>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<LoginModelDto>> sr = new ServiceResponse<List<LoginModelDto>>();
        try
        {
            sr.Data = _mapper.Map<List<LoginModelDto>>(await _db.LoginModel.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<LoginModelDto>> GetFirstOrDefault(Expression<Func<LoginModel, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<LoginModelDto> sr = new ServiceResponse<LoginModelDto>();
        try
        {
            sr.Data = _mapper.Map<LoginModelDto>(await _db.LoginModel.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(LoginModelDto entity)
    {
        try
        {
            _db.LoginModel.Remove(_mapper.Map<LoginModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<LoginModelDto> entities)
    {
        try
        {
            _db.LoginModel.RemoveRange(_mapper.Map<IEnumerable<LoginModel>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<LoginModelDto>> Update(LoginModelDto entity)
    {
        ServiceResponse<LoginModelDto> sr = new ServiceResponse<LoginModelDto>();
        try
        {
            var result = _db.LoginModel.Update(_mapper.Map<LoginModel>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<LoginModelDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
