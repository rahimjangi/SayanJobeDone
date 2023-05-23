using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Client.Services.SignUpModelService;

public class SignUpModelRepository : ISignUpModelRepository
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public SignUpModelRepository(ApplicationDbContext db, Mapper mapper, HttpClient httpClient)
    {
        _db = db;
        _mapper = mapper;
        _httpClient = httpClient;
    }

    public List<SignUpModelDto> EntityProperty { get; set; } = new List<SignUpModelDto>();

    public async Task Add(SignUpModelDto entity)
    {
        try
        {
            await _db.SignUpModel.AddAsync(_mapper.Map<SignUpModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<SignUpModelDto>>> GetAll(Expression<Func<SignUpModel, bool>>? filter = null, Func<IQueryable<SignUpModel>, IOrderedQueryable<SignUpModel>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<SignUpModelDto>> sr = new ServiceResponse<List<SignUpModelDto>>();
        try
        {
            sr.Data = _mapper.Map<List<SignUpModelDto>>(await _db.SignUpModel.ToListAsync());
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<SignUpModelDto>> GetFirstOrDefault(Expression<Func<SignUpModel, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<SignUpModelDto> sr = new ServiceResponse<SignUpModelDto>();
        try
        {
            sr.Data = _mapper.Map<SignUpModelDto>(await _db.SignUpModel.FirstOrDefaultAsync(filter!));
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(SignUpModelDto entity)
    {
        try
        {
            _db.SignUpModel.Remove(_mapper.Map<SignUpModel>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<SignUpModelDto> entities)
    {
        try
        {
            _db.SignUpModel.RemoveRange(_mapper.Map<IEnumerable<SignUpModel>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<SignUpModelDto>> Update(SignUpModelDto entity)
    {
        ServiceResponse<SignUpModelDto> sr = new ServiceResponse<SignUpModelDto>();
        try
        {
            var result = _db.SignUpModel.Update(_mapper.Map<SignUpModel>(entity));
            await _db.SaveChangesAsync();
            sr.Data = _mapper.Map<SignUpModelDto>(result);
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
