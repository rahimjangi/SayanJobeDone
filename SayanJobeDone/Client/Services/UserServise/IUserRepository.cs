using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.UserServise;

public interface IUserRepository : IRepository<UserDto, User>
{
}
