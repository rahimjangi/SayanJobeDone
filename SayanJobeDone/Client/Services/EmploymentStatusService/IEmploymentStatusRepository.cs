using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.EmploymentStatusService;

public interface IEmploymentStatusRepository : IRepository<EmploymentStatusDto, EmploymentStatus>
{
}
