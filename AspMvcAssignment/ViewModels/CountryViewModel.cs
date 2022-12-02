using AspMvcAssignment.Models;
using Microsoft.Build.Framework;

namespace AspMvcAssignment.ViewModels
{
    public class CountryViewModel
    {
        public List<Country> Countries = new List<Country>();
        //public static List<City> Cities = new();
        [Required]
        public string CountryName { get; set; }
        public int CountryId { get; set; }
    }
}
