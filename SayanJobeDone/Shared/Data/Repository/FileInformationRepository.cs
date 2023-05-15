using SayanJobeDone.Shared.Data.Repository.IRepository;
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

    public Task Add(FileInformation entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<FileInformation>> GetAll(Expression<Func<FileInformation, bool>>? filter = null, Func<IQueryable<FileInformation>, IOrderedQueryable<FileInformation>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<FileInformation> GetFirstOrDefault(Expression<Func<FileInformation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(FileInformation entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<FileInformation> entities)
    {
        throw new NotImplementedException();
    }

    public Task<FileInformation> Update(FileInformation entity)
    {
        throw new NotImplementedException();
    }
}
