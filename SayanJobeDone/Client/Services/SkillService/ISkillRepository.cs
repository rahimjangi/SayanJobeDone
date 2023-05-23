using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.SkillService;

public interface ISkillRepository : IRepository<SkillDto, Skill>
{

}
