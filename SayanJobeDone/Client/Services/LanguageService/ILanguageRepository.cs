using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.LanguageService;

public interface ILanguageRepository : IRepository<LanguageDto, Language>
{
}
