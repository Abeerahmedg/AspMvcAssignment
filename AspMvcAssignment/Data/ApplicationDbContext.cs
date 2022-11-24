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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(new Person {Id = 1, Name ="Agatha Christie" , NumberOfBooks= 85, City= "Devon" });
            modelBuilder.Entity<Person>().HasData(new Person { Id= 2, Name="Dan Brown", NumberOfBooks=7, City="New Hampshire" });
            modelBuilder.Entity<Person>().HasData(new Person {Id = 3, Name="Yasuo Uchida", NumberOfBooks=130, City="Tokyo" });
            modelBuilder.Entity<Person>().HasData(new Person {Id=4, Name="Ahmed Tawfik", NumberOfBooks=200, City="Tanta"});

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}

