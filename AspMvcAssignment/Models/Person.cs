using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMvcAssignment.Models
{
    public class Person
    {
        [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Number of books")]
        public int NumberOfBooks { get; set; }


        public int CityId { get; set; }

        public City City { get; set; }




        public List<Language> Languages { get; set; } = new List<Language>();
    }
}
