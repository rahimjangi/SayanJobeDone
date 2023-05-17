using AutoMapper;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Utilities;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Address, AddressDto>().ReverseMap();
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<EducationLevel, EducationLevelDto>().ReverseMap();
        CreateMap<EmploymentStatus, EmploymentStatusDto>().ReverseMap();
        CreateMap<FileInformation, FileInformationDto>().ReverseMap();
        CreateMap<Gender, GenderDto>().ReverseMap();
        CreateMap<Language, LanguageDto>().ReverseMap();
        CreateMap<LocationData, LocationDataDto>().ReverseMap();
        CreateMap<LoginModel, LoginModelDto>().ReverseMap();
        CreateMap<MobilePhone, MobilePhoneDto>().ReverseMap();
        CreateMap<Nationality, NationalityDto>().ReverseMap();
        CreateMap<Occupation, OccupationDto>().ReverseMap();
        CreateMap<PreviousEmployment, PreviousEmploymentDto>().ReverseMap();
        CreateMap<RateType, RateTypeDto>().ReverseMap();
        CreateMap<Service, ServiceDto>().ReverseMap();
        CreateMap<ServiceProviders, ServiceProvidersDto>().ReverseMap();
        CreateMap<ServiceReceiver, ServiceReceiverDto>().ReverseMap();
        CreateMap<SignUpModel, SignUpModelDto>().ReverseMap();
        CreateMap<Skill, SkillDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
    }
}
