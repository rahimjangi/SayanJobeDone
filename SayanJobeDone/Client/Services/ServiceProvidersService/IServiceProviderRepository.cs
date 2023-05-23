using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.ServiceProvidersService;

public interface IServiceProviderRepository : IRepository<ServiceProvidersDto, ServiceProviders>
{
}
