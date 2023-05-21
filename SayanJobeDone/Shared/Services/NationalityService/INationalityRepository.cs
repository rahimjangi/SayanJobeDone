using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.NationalityService;

public interface INationalityRepository : IRepository<NationalityDto, Nationality>
{
}
