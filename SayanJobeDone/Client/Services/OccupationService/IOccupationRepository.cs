using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.OccupationService;

public interface IOccupationRepository : IRepository<OccupationDto, Occupation>
{
}
