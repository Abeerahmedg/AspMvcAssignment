using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int NumberOfBooks { get; set; }

        public int CityId { get; set; }
        public int Id { get; set; }
    }
}
