using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class SignUpModelRepository : ISignUpModelRepository
{
    private readonly ApplicationDbContext _db;

    public SignUpModelRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(SignUpModelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<SignUpModelDto>> GetAll(Expression<Func<SignUpModel, bool>>? filter = null, Func<IQueryable<SignUpModel>, IOrderedQueryable<SignUpModel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<SignUpModelDto> GetFirstOrDefault(Expression<Func<SignUpModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(SignUpModelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<SignUpModelDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<SignUpModelDto> Update(SignUpModelDto entity)
    {
        throw new NotImplementedException();
    }
}
