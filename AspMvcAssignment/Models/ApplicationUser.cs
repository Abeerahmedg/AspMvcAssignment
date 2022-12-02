using Microsoft.AspNetCore.Identity;

namespace AspMvcAssignment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get;  set; }
        public bool Admin { get; set; }
    }
}
