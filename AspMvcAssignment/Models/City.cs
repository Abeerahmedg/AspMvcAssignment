using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
       
        [Required]
        [Display(Name ="City")]
        public string CityName { get; set; }

        //Navigation Properties
        public List<Person> People { get; set; } 

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
