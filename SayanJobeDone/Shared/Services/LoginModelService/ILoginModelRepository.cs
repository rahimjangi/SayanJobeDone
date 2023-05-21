using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.LoginModelService;

public interface ILoginModelRepository : IRepository<LoginModelDto, LoginModel>
{
}
