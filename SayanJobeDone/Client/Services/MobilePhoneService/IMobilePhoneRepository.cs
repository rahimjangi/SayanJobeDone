using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.MobilePhoneService;

public interface IMobilePhoneRepository : IRepository<MobilePhoneDto, MobilePhone>
{
}
