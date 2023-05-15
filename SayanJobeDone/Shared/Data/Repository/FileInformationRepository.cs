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

    public void Add(FileInformation entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<FileInformation> GetAll(Expression<Func<FileInformation, bool>>? filter = null, Func<IQueryable<FileInformation>, IOrderedQueryable<FileInformation>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public FileInformation GetFirstOrDefault(Expression<Func<FileInformation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(FileInformation entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<FileInformation> entities)
    {
        throw new NotImplementedException();
    }
}
