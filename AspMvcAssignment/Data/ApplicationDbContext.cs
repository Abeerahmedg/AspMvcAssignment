using AspMvcAssignment.Models;
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

    }
}
