using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.PreviousEmploymentService;

public interface IPreviousEmploymentRepository : IRepository<PreviousEmploymentDto, PreviousEmployment>
{
}
