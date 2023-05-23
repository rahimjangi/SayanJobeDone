using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.SignUpModelService;

public interface ISignUpModelRepository : IRepository<SignUpModelDto, SignUpModel>
{
}
