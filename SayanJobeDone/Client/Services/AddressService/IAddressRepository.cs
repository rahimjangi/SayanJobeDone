using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.AddressService;

public interface IAddressRepository : IRepository<AddressDto, Address>
{
}
