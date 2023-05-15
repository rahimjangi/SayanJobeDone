using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<EducationLevel> EducationLevels { get; set; } = null!;
        public DbSet<EmploymentStatus> EmploymentStatuses { get; set; } = null!;
        public DbSet<FileInformation> FileInformation { get; set; } = null!;
        public DbSet<Gender> Genders { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<LocationData> LocationDatas { get; set; } = null!;
        public DbSet<LoginModel> LoginModel { get; set; } = null!;
        public DbSet<MobilePhone> MobilePhones { get; set; } = null!;
        public DbSet<Nationality> Nationalities { get; set; } = null!;
        public DbSet<Occupation> Occupations { get; set; } = null!;
        public DbSet<PreviousEmployment> PreviousEmployments { get; set; } = null!;
        public DbSet<RateType> RateTypes { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<ServiceProviders> ServiceProviders { get; set; } = null!;
        public DbSet<ServiceReceiver> ServiceReceivers { get; set; } = null!;
        public DbSet<SignUpModel> SignUpModel { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

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
            modelBuilder.Entity<Gender>().HasData(
                new List<Gender>()
                {
                    new Gender(){Id=1, Name="Male"},
                    new Gender(){Id=2,Name="Female"},
                    new Gender(){Id=3,Name="Transgender"},
                    new Gender(){Id=4,Name="Non-binary"},
                    new Gender(){Id=5,Name="Genderqueer"},
                    new Gender(){Id=6,Name="Neutrois"},
                    new Gender(){Id=7,Name="Bigender"},
                    new Gender(){Id=8,Name="Gender nonconforming"}
                });
            modelBuilder.Entity<Country>().HasData(
                    new List<Country>()
                    {
                        new Country(){Id=1,Name="Austria"},
                        new Country(){Id=2,Name="Belgium"},
                        new Country(){Id=3,Name="Bulgaria"},
                        new Country(){Id=4,Name="Croatia"},
                        new Country(){Id=5,Name="Cyprus"},
                        new Country(){Id=6,Name="Czech Republic"},
                        new Country(){Id=7,Name="Denmark"},
                        new Country(){Id=8,Name="Estonia"},
                        new Country(){Id=9,Name="Finland"},
                        new Country(){Id=10,Name="France"},
                        new Country(){Id=11,Name="Germany"},
                        new Country(){Id=12,Name="Greece"},
                        new Country(){Id=13,Name="Hungary"},
                        new Country(){Id=14,Name="Ireland"},
                        new Country(){Id=15,Name="Italy"},
                        new Country(){Id=16,Name="Latvia"},
                        new Country(){Id=17,Name="Luxembourg"},
                        new Country(){Id=18,Name="Malta"},
                        new Country(){Id=19,Name="Netherlands"},
                        new Country(){Id=20,Name="Poland"},
                        new Country(){Id=21,Name="Portugal"},
                        new Country(){Id=22,Name="Romania"},
                        new Country(){Id=23,Name="Slovakia"},
                        new Country(){Id=24,Name="Slovenia"},
                        new Country(){Id=25,Name="Spain"},
                        new Country(){Id=26,Name="Sweden"},
                        new Country(){Id=27,Name="Lithuania"}
                    }
                );
            modelBuilder.Entity<Language>().HasData(
                    new List<Language>()
                    {
                        new Language(){Id=1,Name="Bulgarian"},
                        new Language(){Id=2,Name="Croatian"},
                        new Language(){Id=3,Name="Czech"},
                        new Language(){Id=4,Name="Danish"},
                        new Language(){Id=5,Name="Dutch"},
                        new Language(){Id=6,Name="English"},
                        new Language(){Id=7,Name="Finnish"},
                        new Language(){Id=8,Name="French"},
                        new Language(){Id=9,Name="German"},
                        new Language(){Id=10,Name="Greek"},
                        new Language(){Id=11,Name="Hungarian"},
                        new Language(){Id=12,Name="Irish"},
                        new Language(){Id=13,Name="Italian"},
                        new Language(){Id=14,Name="Latvian"},
                        new Language(){Id=15,Name="Lithuanian"},
                        new Language(){Id=16,Name="Maltese"},
                        new Language(){Id=17,Name="Polish"},
                        new Language(){Id=18,Name="Portuguese"},
                        new Language(){Id=19,Name="Romanian"},
                        new Language(){Id=20,Name="Slovak"},
                        new Language(){Id=21,Name="Slovene"},
                        new Language(){Id=22,Name="Spanish"},
                        new Language(){Id=23,Name="Bulgarian"},
                        new Language(){Id=24,Name="Swedish"}
                    }
            );
            modelBuilder.Entity<Category>().HasData(
            new List<Category>() {
                new Category(){Id=1,Name="Cleaning",Description="This includes tasks such as sweeping, mopping, vacuuming, dusting, and cleaning various areas of the house like bathrooms, kitchens, bedrooms, and living spaces."},
                new Category(){Id=2,Name="Cooking and Meal Preparation",Description="This involves planning and preparing meals for the family, including shopping for groceries, meal prepping, cooking, and serving food."},
                new Category(){Id=3,Name="Laundry and Ironing",Description="Tasks related to washing, drying, folding, and ironing clothes, bed sheets, towels, and other fabric items."},
                new Category(){Id=4,Name="Childcare",Description="Taking care of children, including supervising their activities, preparing meals for them, helping with homework, and providing general care and supervision."},
                new Category(){Id=5,Name="Elderly Care",Description="Assisting elderly family members with their daily activities, providing companionship, helping with medication management, and ensuring their well-being"},
                new Category(){Id=6,Name="Gardening and Outdoor Maintenance",Description="Taking care of the garden, lawn mowing, watering plants, weeding, and general maintenance of outdoor spaces."},
                new Category(){Id=7,Name="Pet Care",Description="Feeding, walking, grooming, and providing care for pets, including cleaning litter boxes or cages."},
                new Category(){Id=8,Name="Household Organization",Description="Organizing and decluttering rooms, closets, and storage spaces, as well as managing household paperwork and bills."},
                new Category(){Id=9,Name="Home Maintenance",Description="Basic repairs and maintenance tasks such as changing light bulbs, fixing minor plumbing issues, or repairing furniture."},
                new Category(){Id=10,Name="Personal Assistance",Description="Providing assistance with tasks like running errands, shopping, scheduling appointments, and managing household logistics."},
            }

             );
            modelBuilder.Entity<Skill>().HasData(
                    new List<Skill>()
                    {
                        new Skill(){Id=1,Name="Cooking and Meal Preparation",ExperienceLevel=1,CategoryId=1},
                        new Skill(){Id=2,Name="Cleaning and Housekeeping",ExperienceLevel=1,CategoryId=1},
                        new Skill(){Id=3,Name="Laundry and Ironing",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=4,Name="Organization and Decluttering",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=5,Name="Grocery Shopping and Meal Planning",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=6,Name="Childcare and Babysitting",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=7,Name="Elderly Care and Companionship",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=8,Name="Pet Care (feeding, walking, grooming)",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=9,Name="Gardening and Yard Maintenance",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=10,Name="Basic Home Repairs and Maintenance",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=11,Name="Sewing and Mending",ExperienceLevel=1   , CategoryId = 1},
                        new Skill(){Id=12,Name="Home Decorating and Interior Design",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=13,Name="Event Planning and Hosting",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=14,Name="Budgeting and Financial Management",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=15,Name="Time Management and Scheduling",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=16,Name="Communication and Interpersonal Skills",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=17,Name="Problem Solving and Troubleshooting",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=18,Name="First Aid and CPR",ExperienceLevel=1    , CategoryId = 1},
                        new Skill(){Id=19,Name="Driving and Transportation",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=27,Name="Technology Skills (computer use, smartphone usage)",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=20,Name="DIY Projects and Crafts",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=21,Name="Home Security and Safety Awareness",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=22,Name="Personal Care (hairstyling, skincare, grooming)",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=23,Name="Fitness and Exercise Training",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=24,Name="Language Skills (teaching, translation)",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=25,Name="Teaching and Tutoring",ExperienceLevel=1, CategoryId = 1},
                        new Skill(){Id=26,Name="Handyman Skills (basic plumbing, electrical, carpentry)",ExperienceLevel=1, CategoryId = 1},

                    }
                );





















        }
    }
}
