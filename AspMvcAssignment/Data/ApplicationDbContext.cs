using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AspMvcAssignment.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet <City> Cities { get; set; }
        public DbSet <Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        //public DbSet<PersonLanguage> PersonLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //primary keys
            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<City>().HasKey(c => c.CityId);
            modelBuilder.Entity<Country>().HasKey(co => co.CountryId);
            modelBuilder.Entity<Language>().HasKey(l => l.LanguageId);


            // relationships
            //modelBuilder.Entity<City>()
            //    .HasOne(ci => ci.Country)
            //    .WithMany(co => co.Cities)
            //    .HasForeignKey(ci => ci.CountryId);

            //modelBuilder.Entity<Person>()
            //    .HasOne(p => p.City)
            //    .WithMany(ci => ci.People)
            //    .HasForeignKey(p => p.CityId);

            //// relationships (many to many)
            //modelBuilder.Entity<PersonLanguage>()
            //    .HasOne(pl => pl.Person)
            //    .WithMany(p => p.PersonLanguages)
            //    .HasForeignKey(pl => pl.Id);

            //modelBuilder.Entity<PersonLanguage>()
            //    .HasOne(pl => pl.Language)
            //    .WithMany(l => l.PersonLanguages)
            //    .HasForeignKey(pl => pl.LanguageId);


            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, CountryName = "England" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, CountryName = "Canada" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, CountryName = "Egypt" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, CountryName = "Japan" });


            modelBuilder.Entity<City>().HasData(new City { CityId = 1, CityName = "Devon", CountryId = 1 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 2, CityName = "London", CountryId = 1 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 3, CityName = "Ottawa", CountryId = 2 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 4, CityName = "Ontario", CountryId = 2 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 5, CityName = "Tanta", CountryId = 3 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 6, CityName = "Cairo", CountryId = 3 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 7, CityName = "Tokyo", CountryId = 4 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 8, CityName = "Handa", CountryId = 4 });

            modelBuilder.Entity<Person>().HasData(new Person {Id = 1, Name ="Agatha Christie" , NumberOfBooks= 85, CityId= 1 });
            modelBuilder.Entity<Person>().HasData(new Person { Id= 2, Name="Dan Brown", NumberOfBooks=7, CityId =2 });
            modelBuilder.Entity<Person>().HasData(new Person {Id = 3, Name="Yasuo Uchida", NumberOfBooks=130, CityId=7 });
            modelBuilder.Entity<Person>().HasData(new Person {Id=4, Name="Ahmed Tawfik", NumberOfBooks=200, CityId = 6 });
            modelBuilder.Entity<Person>().HasData(new Person { Id =5 , Name = "Ahmed fdssa", NumberOfBooks = 2, CityId = 7 });

            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 1, LanguageName = "English" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 2, LanguageName = "Arabic" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 3, LanguageName = "Swedish" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 4, LanguageName = "Spanish" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 5, LanguageName = "Turkish" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 6, LanguageName = "Chinese" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 7, LanguageName = "Hindi" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 8, LanguageName = "French" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 9, LanguageName = "Danish" });


           

            modelBuilder.Entity<Person>()
                .HasMany(p => p.Languages)
                .WithMany(l => l.People)
                .UsingEntity(j => j.HasData(
                    new { PeopleId = 1, LanguagesLanguageId = 1 },
                    new { PeopleId = 1, LanguagesLanguageId = 6 },
                    new { PeopleId = 2, LanguagesLanguageId = 1 },
                    new { PeopleId = 2, LanguagesLanguageId = 3 },
                    new { PeopleId = 3, LanguagesLanguageId = 9 },
                    new { PeopleId = 3, LanguagesLanguageId = 4 },
                    new { PeopleId = 4, LanguagesLanguageId = 8 },
                    new { PeopleId = 4, LanguagesLanguageId = 2 }
                    ));

            // seeding (user roles and standard account)
            string adminRoleId = Guid.NewGuid().ToString();
            string moderatorRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();


            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = moderatorRoleId, Name = "Moderator", NormalizedName = "MODERATOR" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = userId, Name = "User", NormalizedName = "USER" });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Adminsson",
                Birthdate = "1995-03-22",
                PasswordHash = hasher.HashPassword(null, "password")
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId
            });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableSensitiveDataLogging();
        //}
    }
}

