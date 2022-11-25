using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage="Please enter writer name." )]
        public string Name { get; set; }
        
        [Required]
        [Display(Name= "Number of books")]
        public int NumberOfBooks { get; set; }
        
        
        public int CityId { get; set; }

        public City City { get; set; }

        public List<PersonLanguage> PersonLanguages { get; set; }
    }
}
