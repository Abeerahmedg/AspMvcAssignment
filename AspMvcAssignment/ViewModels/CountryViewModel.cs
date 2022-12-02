using AspMvcAssignment.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace AspMvcAssignment.ViewModels
{
    public class CountryViewModel
    {
        public List<Country> Countries = new List<Country>();
        //public static List<City> Cities = new();
        [Required]
        [Display (Name = "Country name")]
        public string CountryName { get; set; }
        public int CountryId { get; set; }
    }
}
