using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AddressDto> Addresses { get; set; } = null!;
        public DbSet<CategoryDto> Categories { get; set; } = null!;
        public DbSet<CityDto> Cities { get; set; } = null!;
        public DbSet<CountryDto> Countries { get; set; } = null!;
        public DbSet<EducationLevelDto> EducationLevels { get; set; } = null!;
        public DbSet<EmploymentStatusDto> EmploymentStatuses { get; set; } = null!;
        public DbSet<FileInformationDto> FileInformation { get; set; } = null!;
        public DbSet<GenderDto> Genders { get; set; } = null!;
        public DbSet<LanguageDto> Languages { get; set; } = null!;
        public DbSet<LocationDataDto> LocationDatas { get; set; } = null!;
        public DbSet<LoginModelDto> LoginModel { get; set; } = null!;
        public DbSet<MobilePhoneDto> MobilePhones { get; set; } = null!;
        public DbSet<NationalityDto> Nationalities { get; set; } = null!;
        public DbSet<OccupationDto> Occupations { get; set; } = null!;
        public DbSet<PreviousEmploymentDto> PreviousEmployments { get; set; } = null!;
        public DbSet<RateTypeDto> RateTypes { get; set; } = null!;
        public DbSet<ServiceDto> Services { get; set; } = null!;
        public DbSet<ServiceProvidersDto> ServiceProviders { get; set; } = null!;
        public DbSet<ServiceReceiverDto> ServiceReceivers { get; set; } = null!;
        public DbSet<SignUpModelDto> SignUpModel { get; set; } = null!;
        public DbSet<SkillDto> Skills { get; set; } = null!;
        public DbSet<UserDto> Users { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the relationships between entities

            //modelBuilder.Entity<Service>()
            //    .HasOne(s => s.ServiceProvider)
            //    .WithMany(sp => sp.Services)
            //    .HasForeignKey(s => s.ServiceProviderId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Service>()
            //    .HasOne(s => s.ServiceReceiver)
            //    .WithMany(sr => sr.ServicesReceived)
            //    .HasForeignKey(s => s.ServiceReceiverId)
            //    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GenderDto>().HasData(
                new List<GenderDto>()
                {
                    new GenderDto(){Id=1, Name="Male"},
                    new GenderDto(){Id=2,Name="Female"},
                    new GenderDto(){Id=3,Name="Transgender"},
                    new GenderDto(){Id=4,Name="Non-binary"},
                    new GenderDto(){Id=5,Name="Genderqueer"},
                    new GenderDto(){Id=6,Name="Neutrois"},
                    new GenderDto(){Id=7,Name="Bigender"},
                    new GenderDto(){Id=8,Name="Gender nonconforming"}
                });
            modelBuilder.Entity<CountryDto>().HasData(
                    new List<CountryDto>()
                    {
                        new CountryDto(){Id=1,Name="Austria"},
                        new CountryDto(){Id=2,Name="Belgium"},
                        new CountryDto(){Id=3,Name="Bulgaria"},
                        new CountryDto(){Id=4,Name="Croatia"},
                        new CountryDto(){Id=5,Name="Cyprus"},
                        new CountryDto(){Id=6,Name="Czech Republic"},
                        new CountryDto(){Id=7,Name="Denmark"},
                        new CountryDto(){Id=8,Name="Estonia"},
                        new CountryDto(){Id=9,Name="Finland"},
                        new CountryDto(){Id=10,Name="France"},
                        new CountryDto(){Id=11,Name="Germany"},
                        new CountryDto(){Id=12,Name="Greece"},
                        new CountryDto(){Id=13,Name="Hungary"},
                        new CountryDto(){Id=14,Name="Ireland"},
                        new CountryDto(){Id=15,Name="Italy"},
                        new CountryDto(){Id=16,Name="Latvia"},
                        new CountryDto(){Id=17,Name="Luxembourg"},
                        new CountryDto(){Id=18,Name="Malta"},
                        new CountryDto(){Id=19,Name="Netherlands"},
                        new CountryDto(){Id=20,Name="Poland"},
                        new CountryDto(){Id=21,Name="Portugal"},
                        new CountryDto(){Id=22,Name="Romania"},
                        new CountryDto(){Id=23,Name="Slovakia"},
                        new CountryDto(){Id=24,Name="Slovenia"},
                        new CountryDto(){Id=25,Name="Spain"},
                        new CountryDto(){Id=26,Name="Sweden"},
                        new CountryDto(){Id=27,Name="Lithuania"}
                    }
                );
            modelBuilder.Entity<LanguageDto>().HasData(
                    new List<LanguageDto>()
                    {
                        new LanguageDto(){Id=1,Name="Bulgarian"},
                        new LanguageDto(){Id=2,Name="Croatian"},
                        new LanguageDto(){Id=3,Name="Czech"},
                        new LanguageDto(){Id=4,Name="Danish"},
                        new LanguageDto(){Id=5,Name="Dutch"},
                        new LanguageDto(){Id=6,Name="English"},
                        new LanguageDto(){Id=7,Name="Finnish"},
                        new LanguageDto(){Id=8,Name="French"},
                        new LanguageDto(){Id=9,Name="German"},
                        new LanguageDto(){Id=10,Name="Greek"},
                        new LanguageDto(){Id=11,Name="Hungarian"},
                        new LanguageDto(){Id=12,Name="Irish"},
                        new LanguageDto(){Id=13,Name="Italian"},
                        new LanguageDto(){Id=14,Name="Latvian"},
                        new LanguageDto(){Id=15,Name="Lithuanian"},
                        new LanguageDto(){Id=16,Name="Maltese"},
                        new LanguageDto(){Id=17,Name="Polish"},
                        new LanguageDto(){Id=18,Name="Portuguese"},
                        new LanguageDto(){Id=19,Name="Romanian"},
                        new LanguageDto(){Id=20,Name="Slovak"},
                        new LanguageDto(){Id=21,Name="Slovene"},
                        new LanguageDto(){Id=22,Name="Spanish"},
                        new LanguageDto(){Id=23,Name="Bulgarian"},
                        new LanguageDto(){Id=24,Name="Swedish"}
                    }
            );
            modelBuilder.Entity<CategoryDto>().HasData(
            new List<CategoryDto>() {
                new CategoryDto(){Id=1,Name="Cleaning",Description="This includes tasks such as sweeping, mopping, vacuuming, dusting, and cleaning various areas of the house like bathrooms, kitchens, bedrooms, and living spaces."},
                new CategoryDto(){Id=2,Name="Cooking and Meal Preparation",Description="This involves planning and preparing meals for the family, including shopping for groceries, meal prepping, cooking, and serving food."},
                new CategoryDto(){Id=3,Name="Laundry and Ironing",Description="Tasks related to washing, drying, folding, and ironing clothes, bed sheets, towels, and other fabric items."},
                new CategoryDto(){Id=4,Name="Childcare",Description="Taking care of children, including supervising their activities, preparing meals for them, helping with homework, and providing general care and supervision."},
                new CategoryDto(){Id=5,Name="Elderly Care",Description="Assisting elderly family members with their daily activities, providing companionship, helping with medication management, and ensuring their well-being"},
                new CategoryDto(){Id=6,Name="Gardening and Outdoor Maintenance",Description="Taking care of the garden, lawn mowing, watering plants, weeding, and general maintenance of outdoor spaces."},
                new CategoryDto(){Id=7,Name="Pet Care",Description="Feeding, walking, grooming, and providing care for pets, including cleaning litter boxes or cages."},
                new CategoryDto(){Id=8,Name="Household Organization",Description="Organizing and decluttering rooms, closets, and storage spaces, as well as managing household paperwork and bills."},
                new CategoryDto(){Id=9,Name="Home Maintenance",Description="Basic repairs and maintenance tasks such as changing light bulbs, fixing minor plumbing issues, or repairing furniture."},
                new CategoryDto(){Id=10,Name="Personal Assistance",Description="Providing assistance with tasks like running errands, shopping, scheduling appointments, and managing household logistics."},
            }

             );
            modelBuilder.Entity<SkillDto>().HasData(
                    new List<SkillDto>()
                    {
                        new SkillDto(){Id=1,Name="Cooking and Meal Preparation",ExperienceLevel=1,CategoryId=1},
                        new SkillDto(){Id=2,Name="Cleaning and Housekeeping",ExperienceLevel=1,CategoryId=1},
                        new SkillDto(){Id=3,Name="Laundry and Ironing",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=4,Name="Organization and Decluttering",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=5,Name="Grocery Shopping and Meal Planning",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=6,Name="Childcare and Babysitting",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=7,Name="Elderly Care and Companionship",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=8,Name="Pet Care (feeding, walking, grooming)",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=9,Name="Gardening and Yard Maintenance",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=10,Name="Basic Home Repairs and Maintenance",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=11,Name="Sewing and Mending",ExperienceLevel=1   , CategoryId = 1},
                        new SkillDto(){Id=12,Name="Home Decorating and Interior Design",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=13,Name="Event Planning and Hosting",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=14,Name="Budgeting and Financial Management",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=15,Name="Time Management and Scheduling",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=16,Name="Communication and Interpersonal Skills",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=17,Name="Problem Solving and Troubleshooting",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=18,Name="First Aid and CPR",ExperienceLevel=1    , CategoryId = 1},
                        new SkillDto(){Id=19,Name="Driving and Transportation",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=27,Name="Technology Skills (computer use, smartphone usage)",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=20,Name="DIY Projects and Crafts",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=21,Name="Home Security and Safety Awareness",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=22,Name="Personal Care (hairstyling, skincare, grooming)",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=23,Name="Fitness and Exercise Training",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=24,Name="Language Skills (teaching, translation)",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=25,Name="Teaching and Tutoring",ExperienceLevel=1, CategoryId = 1},
                        new SkillDto(){Id=26,Name="Handyman Skills (basic plumbing, electrical, carpentry)",ExperienceLevel=1, CategoryId = 1},

                    }
                );





















        }
    }
}
