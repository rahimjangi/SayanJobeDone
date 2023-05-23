using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.FileInformationService;

public interface IFileInformationRepository : IRepository<FileInformationDto, FileInformation>
{
}
