using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AspMvcAssignment.Data
{
    public class ApplicationDbContext :DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}

