using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class LoginModelRepository : ILoginModelRepository
{
    private readonly ApplicationDbContext _db;

    public LoginModelRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public Task Add(LoginModelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<LoginModelDto>> GetAll(Expression<Func<LoginModel, bool>>? filter = null, Func<IQueryable<LoginModel>, IOrderedQueryable<LoginModel>>? orderby = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task<LoginModelDto> GetFirstOrDefault(Expression<Func<LoginModel, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(LoginModelDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<LoginModelDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<LoginModelDto> Update(LoginModelDto entity)
    {
        throw new NotImplementedException();
    }
}
