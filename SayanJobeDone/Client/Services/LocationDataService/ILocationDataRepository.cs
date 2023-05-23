using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.LocationDataService;

public interface ILocationDataRepository : IRepository<LocationDataDto, LocationData>
{
}
