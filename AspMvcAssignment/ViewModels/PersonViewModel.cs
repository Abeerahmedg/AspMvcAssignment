using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Number of books")]
        public int NumberOfBooks { get; set; }

        public int CityId { get; set; }
        public int Id { get; set; }
    }
}
