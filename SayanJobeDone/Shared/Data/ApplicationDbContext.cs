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
        public DbSet<ServiceProvider> ServiceProviders { get; set; } = null!;
        public DbSet<ServiceReceiver> ServiceReceivers { get; set; } = null!;
        public DbSet<SignUpModel> SignUpModel { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection
            optionsBuilder.UseSqlServer("YourConnectionString");
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
                    new Gender(){Name="Male"},
                    new Gender(){Name="Female"},
                    new Gender(){Name="Transgender"},
                    new Gender(){Name="Non-binary"},
                    new Gender(){Name="Genderqueer"},
                    new Gender(){Name="Neutrois"},
                    new Gender(){Name="Bigender"},
                    new Gender(){Name="Gender nonconforming"}
                });
            modelBuilder.Entity<Country>().HasData(
                    new List<Country>()
                    {
                        new Country(){Name="Austria"},
                        new Country(){Name="Belgium"},
                        new Country(){Name="Bulgaria"},
                        new Country(){Name="Croatia"},
                        new Country(){Name="Cyprus"},
                        new Country(){Name="Czech Republic"},
                        new Country(){Name="Denmark"},
                        new Country(){Name="Estonia"},
                        new Country(){Name="Finland"},
                        new Country(){Name="France"},
                        new Country(){Name="Germany"},
                        new Country(){Name="Greece"},
                        new Country(){Name="Hungary"},
                        new Country(){Name="Ireland"},
                        new Country(){Name="Italy"},
                        new Country(){Name="Latvia"},
                        new Country(){Name="Lithuania"},
                        new Country(){Name="Luxembourg"},
                        new Country(){Name="Malta"},
                        new Country(){Name="Netherlands"},
                        new Country(){Name="Poland"},
                        new Country(){Name="Portugal"},
                        new Country(){Name="Romania"},
                        new Country(){Name="Slovakia"},
                        new Country(){Name="Slovenia"},
                        new Country(){Name="Spain"},
                        new Country(){Name="Sweden"}
                    }
                );
            modelBuilder.Entity<Language>().HasData(
                    new List<Language>()
                    {
                        new Language(){Name="Bulgarian"},
                        new Language(){Name="Croatian"},
                        new Language(){Name="Czech"},
                        new Language(){Name="Danish"},
                        new Language(){Name="Dutch"},
                        new Language(){Name="English"},
                        new Language(){Name="Finnish"},
                        new Language(){Name="French"},
                        new Language(){Name="German"},
                        new Language(){Name="Greek"},
                        new Language(){Name="Hungarian"},
                        new Language(){Name="Irish"},
                        new Language(){Name="Italian"},
                        new Language(){Name="Latvian"},
                        new Language(){Name="Lithuanian"},
                        new Language(){Name="Maltese"},
                        new Language(){Name="Polish"},
                        new Language(){Name="Portuguese"},
                        new Language(){Name="Romanian"},
                        new Language(){Name="Slovak"},
                        new Language(){Name="Slovene"},
                        new Language(){Name="Spanish"},
                        new Language(){Name="Bulgarian"},
                        new Language(){Name="Swedish"}
                    }
            );
            modelBuilder.Entity<Category>().HasData(
            new List<Category>() {
                new Category(){Name="Cleaning",Description="This includes tasks such as sweeping, mopping, vacuuming, dusting, and cleaning various areas of the house like bathrooms, kitchens, bedrooms, and living spaces."},
                new Category(){Name="Cooking and Meal Preparation",Description="This involves planning and preparing meals for the family, including shopping for groceries, meal prepping, cooking, and serving food."},
                new Category(){Name="Laundry and Ironing",Description="Tasks related to washing, drying, folding, and ironing clothes, bed sheets, towels, and other fabric items."},
                new Category(){Name="Childcare",Description="Taking care of children, including supervising their activities, preparing meals for them, helping with homework, and providing general care and supervision."},
                new Category(){Name="Elderly Care",Description="Assisting elderly family members with their daily activities, providing companionship, helping with medication management, and ensuring their well-being"},
                new Category(){Name="Gardening and Outdoor Maintenance",Description="Taking care of the garden, lawn mowing, watering plants, weeding, and general maintenance of outdoor spaces."},
                new Category(){Name="Pet Care",Description="Feeding, walking, grooming, and providing care for pets, including cleaning litter boxes or cages."},
                new Category(){Name="Household Organization",Description="Organizing and decluttering rooms, closets, and storage spaces, as well as managing household paperwork and bills."},
                new Category(){Name="Home Maintenance",Description="Basic repairs and maintenance tasks such as changing light bulbs, fixing minor plumbing issues, or repairing furniture."},
                new Category(){Name="Personal Assistance",Description="Providing assistance with tasks like running errands, shopping, scheduling appointments, and managing household logistics."},
            }

             );
            modelBuilder.Entity<Skill>().HasData(
                    new List<Skill>()
                    {
                        new Skill(){Name="Cooking and Meal Preparation",ExperienceLevel=1},
                        new Skill(){Name="Cleaning and Housekeeping",ExperienceLevel=1},
                        new Skill(){Name="Laundry and Ironing",ExperienceLevel=1},
                        new Skill(){Name="Organization and Decluttering",ExperienceLevel=1},
                        new Skill(){Name="Grocery Shopping and Meal Planning",ExperienceLevel=1},
                        new Skill(){Name="Childcare and Babysitting",ExperienceLevel=1},
                        new Skill(){Name="Elderly Care and Companionship",ExperienceLevel=1},
                        new Skill(){Name="Pet Care (feeding, walking, grooming)",ExperienceLevel=1},
                        new Skill(){Name="Gardening and Yard Maintenance",ExperienceLevel=1},
                        new Skill(){Name="Basic Home Repairs and Maintenance",ExperienceLevel=1},
                        new Skill(){Name="Sewing and Mending",ExperienceLevel=1},
                        new Skill(){Name="Home Decorating and Interior Design",ExperienceLevel=1},
                        new Skill(){Name="Event Planning and Hosting",ExperienceLevel=1},
                        new Skill(){Name="Budgeting and Financial Management",ExperienceLevel=1},
                        new Skill(){Name="Time Management and Scheduling",ExperienceLevel=1},
                        new Skill(){Name="Communication and Interpersonal Skills",ExperienceLevel=1},
                        new Skill(){Name="Problem Solving and Troubleshooting",ExperienceLevel=1},
                        new Skill(){Name="First Aid and CPR",ExperienceLevel=1},
                        new Skill(){Name="Driving and Transportation",ExperienceLevel=1},
                        new Skill(){Name="Technology Skills (computer use, smartphone usage)",ExperienceLevel=1},
                        new Skill(){Name="DIY Projects and Crafts",ExperienceLevel=1},
                        new Skill(){Name="Home Security and Safety Awareness",ExperienceLevel=1},
                        new Skill(){Name="Personal Care (hairstyling, skincare, grooming)",ExperienceLevel=1},
                        new Skill(){Name="Fitness and Exercise Training",ExperienceLevel=1},
                        new Skill(){Name="Language Skills (teaching, translation)",ExperienceLevel=1},
                        new Skill(){Name="Teaching and Tutoring",ExperienceLevel=1},
                        new Skill(){Name="Handyman Skills (basic plumbing, electrical, carpentry)",ExperienceLevel=1},

                    }
                );





















        }
    }
}
