using System.ComponentModel.DataAnnotations;
using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
         public string Name { get; set; }
        [Required]
        public int NumberOfBooks { get; set; }
        [Required]
        public string City { get; set; }
  
       
    }
}
