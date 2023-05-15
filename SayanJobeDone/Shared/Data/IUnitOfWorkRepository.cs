using SayanJobeDone.Shared.Data.Repository.IRepository;

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
