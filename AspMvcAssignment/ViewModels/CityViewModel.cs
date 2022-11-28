using AspMvcAssignment.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AspMvcAssignment.ViewModels
{
    public class CityViewModel
    {
        public List<City> Cities { get; set; } =new List<City>();

        
        [Display(Name ="City")]
        [Required]
        public string? CityName { get; set; }

        public Country? Country { get; set; }
        public int CountryId { get; set; }
    }
}
