using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class CountryViewModel
    {
        public List<Country> Countries = new List<Country>();
        //public static List<City> Cities = new();
        public string CountryName { get; set; }
    }
}
