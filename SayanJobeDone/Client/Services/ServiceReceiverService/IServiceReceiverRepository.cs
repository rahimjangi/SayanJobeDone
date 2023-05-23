using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.ServiceReceiverService;

public interface IServiceReceiverRepository : IRepository<ServiceReceiverDto, ServiceReceiver>
{
}
