using SayanJobeDone.Shared.Services.AddressService;
using SayanJobeDone.Shared.Services.CategoryService;
using SayanJobeDone.Shared.Services.CityService;
using SayanJobeDone.Shared.Services.CountryService;
using SayanJobeDone.Shared.Services.EducationLevelService;
using SayanJobeDone.Shared.Services.EmploymentStatusService;
using SayanJobeDone.Shared.Services.FileInformationService;
using SayanJobeDone.Shared.Services.GenderService;
using SayanJobeDone.Shared.Services.LanguageService;
using SayanJobeDone.Shared.Services.LocationDataService;
using SayanJobeDone.Shared.Services.LoginModelService;
using SayanJobeDone.Shared.Services.MobilePhoneService;
using SayanJobeDone.Shared.Services.NationalityService;
using SayanJobeDone.Shared.Services.OccupationService;
using SayanJobeDone.Shared.Services.PreviousEmploymentService;
using SayanJobeDone.Shared.Services.RateTypeService;
using SayanJobeDone.Shared.Services.ServiceProvidersService;
using SayanJobeDone.Shared.Services.ServiceReceiverService;
using SayanJobeDone.Shared.Services.ServiceService;
using SayanJobeDone.Shared.Services.SignUpModelService;
using SayanJobeDone.Shared.Services.SkillService;
using SayanJobeDone.Shared.Services.UserServise;

namespace SayanJobeDone.Shared.Data;

public interface IUnitOfWorkRepository
{
    IAddressRepository Address { get; }
    ICategoryRepository Category { get; }
    ICityRepository City { get; }
    ICountryRepository Country { get; }
    IEducationLevelRepository EducationLevel { get; }
    IEmploymentStatusRepository EmploymentStatus { get; }
    IFileInformationRepository FileInformation { get; }
    IGenderRepository Gender { get; }
    ILanguageRepository Language { get; }
    ILocationDataRepository LocationData { get; }
    ILoginModelRepository LoginModel { get; }
    IMobilePhoneRepository MobilePhone { get; }
    INationalityRepository Nationality { get; }
    IOccupationRepository Occupation { get; }
    IPreviousEmploymentRepository PreviousEmployment { get; }
    IRateTypeRepository RateType { get; }
    IServiceRepository Service { get; }
    IServiceProviderRepository ServiceProviders { get; }
    IServiceReceiverRepository ServiceReceiver { get; }
    ISignUpModelRepository SignUpModel { get; }
    ISkillRepository Skill { get; }
    IUserRepository User { get; }
}
