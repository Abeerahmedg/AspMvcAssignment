using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
       
        [Required]
        public string cityName { get; set; }

        //Navigation Properties
        public List<Person>People { get; set; } 
        public int CountryId { get; set; }
        public Country country { get; set; }
    }
}
