using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.FileInformationService;

public class FileInformationRepository : IFileInformationRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public FileInformationRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(FileInformationDto entity)
    {
        try
        {
            await _db.FileInformation.AddAsync(_mapper.Map<FileInformation>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<List<FileInformationDto>> GetAll(Expression<Func<FileInformation, bool>>? filter = null, Func<IQueryable<FileInformation>, IOrderedQueryable<FileInformation>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<List<FileInformationDto>>(await _db.FileInformation.ToListAsync());
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<FileInformationDto> GetFirstOrDefault(Expression<Func<FileInformation, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            return _mapper.Map<FileInformationDto>(await _db.FileInformation.FirstOrDefaultAsync(filter!));
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task Remove(FileInformationDto entity)
    {
        try
        {
            _db.FileInformation.Remove(_mapper.Map<FileInformation>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task RemoveRange(IEnumerable<FileInformationDto> entities)
    {
        try
        {
            _db.FileInformation.RemoveRange(_mapper.Map<IEnumerable<FileInformation>>(entities));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<FileInformationDto> Update(FileInformationDto entity)
    {
        try
        {
            var result = _db.FileInformation.Update(_mapper.Map<FileInformation>(entity));
            await _db.SaveChangesAsync();
            return _mapper.Map<FileInformationDto>(result);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
