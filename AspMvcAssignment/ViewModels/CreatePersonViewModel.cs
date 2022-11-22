using System.ComponentModel.DataAnnotations;
using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Number Of Books" )]
        public int NumberOfBooks { get; set; }
        [Required]
        public string City { get; set; }


       // public bool IsValidForm()
       // {
       //     return ((!string.IsNullOrWhiteSpace(Name))
       //         && (!string.)
       //} 
    }
}
