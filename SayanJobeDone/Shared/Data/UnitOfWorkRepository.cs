using SayanJobeDone.Shared.Data.Repository;
using SayanJobeDone.Shared.Data.Repository.IRepository;

namespace SayanJobeDone.Shared.Data;

public class UnitOfWorkRepository : IUnitOfWorkRepository
{
    private readonly ApplicationDbContext _db;
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


    public UnitOfWorkRepository(ApplicationDbContext db)
    {
        _db = db;
        Address = new AddressRepository(_db);
        Category = new CategoryRepository(_db);
        City = new CityRepository(_db);
        Country = new CountryRepository(_db);
        EducationLevel = new EducationLevelRepository(_db);
        EmploymentStatus = new EmploymentStatusRepository(_db);
        FileInformation = new FileInformationRepository(_db);
        Gender = new GenderRepository(_db);
        Language = new LanguageRepository(_db);
        LocationData = new LocationDataRepository(_db);
        LoginModel = new LoginModelRepository(_db);
        MobilePhone = new MobilePhoneRepository(_db);
        Nationality = new NationalityRepository(_db);
        Occupation = new OccupationRepository(_db);
        PreviousEmployment = new PreviousEmploymentRepository(_db);
        RateType = new RateTypeRepository(_db);
        ServiceProviders = new ServiceProviderRepository(_db);
        ServiceReceiver = new ServiceReceiverRepository(_db);
        Service = new ServiceRepository(_db);
        SignUpModel = new SignUpModelRepository(_db);
        Skill = new SkillRepository(_db);
        User = new UserRepository(_db);
    }
}
