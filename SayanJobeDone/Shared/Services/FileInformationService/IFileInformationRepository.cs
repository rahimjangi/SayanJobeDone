using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.FileInformationService;

public interface IFileInformationRepository : IRepository<FileInformationDto, FileInformation>
{
}
