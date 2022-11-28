using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.Models
{

    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        public string LanguageName { get; set; }

        public List<Person> People { get; set; } = new List<Person>();
        public List<Language> Languages { get; set; } = new List<Language>();
    }
}
