using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.GenderService;

public interface IGenderRepository : IRepository<GenderDto, Gender>
{
}
