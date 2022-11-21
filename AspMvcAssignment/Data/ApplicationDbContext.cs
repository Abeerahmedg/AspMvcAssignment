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

            modelBuilder.Entity<Person>().HasData(new Person ( Guid.NewGuid().ToString(), "Agatha Christie", 85, "Devon"));
            modelBuilder.Entity<Person>().HasData(new Person (Guid.NewGuid().ToString(),"Dan Brown",7,"New Hampshire"));
            modelBuilder.Entity<Person>().HasData(new Person (Guid.NewGuid().ToString(),"Yasuo Uchida",130,"Tokyo"));
            modelBuilder.Entity<Person>().HasData(new Person (Guid.NewGuid().ToString(),"Ahmed Tawfik",200,"Tanta"));

        }

    }
}

