using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspMvcAssignment.Models
{
    public class PersonLanguage
    {
        [Display(Name = "Person")]
        public int Id { get; set; }
        public Person Person { get; set; }

        [Display(Name = "Language")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        //public List<Person> People { get; set; }
        //public List<Language> Languages { get; set; }
        //public List<PersonLanguage> PersonLanguages { get; set; }
    }
}
