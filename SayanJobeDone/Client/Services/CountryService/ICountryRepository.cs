using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Client.Services.CountryService;

public interface ICountryRepository : IRepository<CountryDto, Country>
{
}
