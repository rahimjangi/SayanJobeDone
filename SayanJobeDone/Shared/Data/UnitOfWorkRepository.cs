using AutoMapper;
using SayanJobeDone.Shared.Data.Repository;
using SayanJobeDone.Shared.Data.Repository.IRepository;

namespace SayanJobeDone.Shared.Data;

public class UnitOfWorkRepository : IUnitOfWorkRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;
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


    public UnitOfWorkRepository(ApplicationDbContext db, Mapper mapper)
    {
        _mapper = mapper;
        _db = db;
        Address = new AddressRepository(_db, _mapper);
        Category = new CategoryRepository(_db, _mapper);
        City = new CityRepository(_db, _mapper);
        Country = new CountryRepository(_db, _mapper);
        EducationLevel = new EducationLevelRepository(_db, _mapper);
        EmploymentStatus = new EmploymentStatusRepository(_db, _mapper);
        FileInformation = new FileInformationRepository(_db, _mapper);
        Gender = new GenderRepository(_db, _mapper);
        Language = new LanguageRepository(_db, _mapper);
        LocationData = new LocationDataRepository(_db, _mapper);
        LoginModel = new LoginModelRepository(_db, _mapper);
        MobilePhone = new MobilePhoneRepository(_db, _mapper);
        Nationality = new NationalityRepository(_db, _mapper);
        Occupation = new OccupationRepository(_db, _mapper);
        PreviousEmployment = new PreviousEmploymentRepository(_db, _mapper);
        RateType = new RateTypeRepository(_db, _mapper);
        ServiceProviders = new ServiceProviderRepository(_db, _mapper);
        ServiceReceiver = new ServiceReceiverRepository(_db, _mapper);
        Service = new ServiceRepository(_db, _mapper);
        SignUpModel = new SignUpModelRepository(_db, _mapper);
        Skill = new SkillRepository(_db, _mapper);
        User = new UserRepository(_db, _mapper);
    }
}
