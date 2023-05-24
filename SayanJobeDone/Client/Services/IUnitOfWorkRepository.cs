using SayanJobeDone.Client.Services.AddressService;
using SayanJobeDone.Client.Services.CagegoryService;
using SayanJobeDone.Client.Services.CityService;
using SayanJobeDone.Client.Services.CountryService;
using SayanJobeDone.Client.Services.EducationLevelService;
using SayanJobeDone.Client.Services.EmploymentStatusService;
using SayanJobeDone.Client.Services.FileInformationService;
using SayanJobeDone.Client.Services.GenderService;
using SayanJobeDone.Client.Services.LanguageService;
using SayanJobeDone.Client.Services.LocationDataService;
using SayanJobeDone.Client.Services.LoginModelService;
using SayanJobeDone.Client.Services.MobilePhoneService;
using SayanJobeDone.Client.Services.NationalityService;
using SayanJobeDone.Client.Services.OccupationService;
using SayanJobeDone.Client.Services.PreviousEmploymentService;
using SayanJobeDone.Client.Services.RateTypeService;
using SayanJobeDone.Client.Services.ServiceProvidersService;
using SayanJobeDone.Client.Services.ServiceReceiverService;
using SayanJobeDone.Client.Services.ServiceService;
using SayanJobeDone.Client.Services.SignUpModelService;
using SayanJobeDone.Client.Services.SkillService;
using SayanJobeDone.Client.Services.UserServise;

namespace SayanJobeDone.Client.Services;

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
