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

public class UnitOfWorkRepository : IUnitOfWorkRepository
{
    private readonly HttpClient _httpClient;
    public IAddressRepository Address { get; }
    public ICategoryRepository Category { get; }
    public ICityRepository City { get; }
    public ICountryRepository Country { get; }
    public IEducationLevelRepository EducationLevel { get; }
    public IEmploymentStatusRepository EmploymentStatus { get; }
    public IFileInformationRepository FileInformation { get; }
    public IGenderRepository Gender { get; }
    public ILanguageRepository Language { get; }
    public ILocationDataRepository LocationData { get; }
    public ILoginModelRepository LoginModel { get; }
    public IMobilePhoneRepository MobilePhone { get; }
    public INationalityRepository Nationality { get; }
    public IOccupationRepository Occupation { get; }
    public IPreviousEmploymentRepository PreviousEmployment { get; }
    public IRateTypeRepository RateType { get; }
    public IServiceProviderRepository ServiceProviders { get; }
    public IServiceReceiverRepository ServiceReceiver { get; }
    public IServiceRepository Service { get; }
    public ISignUpModelRepository SignUpModel { get; }
    public ISkillRepository Skill { get; }
    public IUserRepository User { get; }


    public UnitOfWorkRepository(HttpClient httpClient)
    {

        Address = new AddressRepository(_httpClient);
        Category = new CategoryRepository(_httpClient);
        City = new CityRepository(_httpClient);
        Country = new CountryRepository(_httpClient);
        EducationLevel = new EducationLevelRepository(_httpClient);
        EmploymentStatus = new EmploymentStatusRepository(_httpClient);
        FileInformation = new FileInformationRepository(_httpClient);
        Gender = new GenderRepository(_httpClient);
        Language = new LanguageRepository(_httpClient);
        LocationData = new LocationDataRepository(_httpClient);
        LoginModel = new LoginModelRepository(_httpClient);
        MobilePhone = new MobilePhoneRepository(_httpClient);
        Nationality = new NationalityRepository(_httpClient);
        Occupation = new OccupationRepository(_httpClient);
        PreviousEmployment = new PreviousEmploymentRepository(_httpClient);
        RateType = new RateTypeRepository(_httpClient);
        ServiceProviders = new ServiceProviderRepository(_httpClient);
        ServiceReceiver = new ServiceReceiverRepository(_httpClient);
        Service = new ServiceRepository(_httpClient);
        SignUpModel = new SignUpModelRepository(_httpClient);
        Skill = new SkillRepository(_httpClient);
        User = new UserRepository(_httpClient);
        _httpClient = httpClient;
    }
}
