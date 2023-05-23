using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.EmploymentStatusService;

public interface IEmploymentStatusRepository : IRepository<EmploymentStatusDto, EmploymentStatus>
{
}
