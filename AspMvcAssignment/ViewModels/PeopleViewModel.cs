
using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class PeopleViewModel : CreatePersonViewModel
    {
        public static List<Person> PeopleList { get; set; } = new List<Person>();
       // public string Search { get; set; }
        public List<Person> tempList { get; set; } = new List<Person>();

    }
}
