using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SayanJobeDone.Client.Services.FileInformationService;

public class FileInformationRepository : IFileInformationRepository
{
    private readonly HttpClient _httpClient;

    public FileInformationRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<FileInformationDto> EntityProperty { get; set; } = new List<FileInformationDto>();

    public Task Add(FileInformationDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResponse<List<FileInformationDto>>> GetAll(Expression<Func<FileInformation, bool>>? filter = null, Func<IQueryable<FileInformation>, IOrderedQueryable<FileInformation>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<FileInformationDto>> sr = new ServiceResponse<List<FileInformationDto>>();
        try
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<FileInformationDto>>>("api/FileInformation/GetAll");
            if (result != null && result.Status && result.Data != null)
            {
                EntityProperty = result.Data;
            }
            return sr;


        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public Task<ServiceResponse<FileInformationDto>> GetFirstOrDefault(Expression<Func<FileInformation, bool>>? filter = null, string? includeProperties = null)
    {
        throw new NotImplementedException();
    }

    public Task Remove(FileInformationDto entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<FileInformationDto> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<FileInformationDto>> Update(FileInformationDto entity)
    {
        throw new NotImplementedException();
    }
}
