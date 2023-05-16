using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class FileInformationRepository : IFileInformationRepository
{
    private readonly ApplicationDbContext _db;

    public FileInformationRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(FileInformationDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<FileInformationDto>> GetAll(Expression<Func<FileInformation, bool>>? filter = null, Func<IQueryable<FileInformation>, IOrderedQueryable<FileInformation>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<FileInformationDto> GetFirstOrDefault(Expression<Func<FileInformation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(FileInformationDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<FileInformationDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<FileInformationDto> Update(FileInformationDto entity)
    {
        throw new NotImplementedException();
    }
}
