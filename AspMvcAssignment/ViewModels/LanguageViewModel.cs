using AspMvcAssignment.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspMvcAssignment.ViewModels
{
    public class LanguageViewModel
    {
        [Required]
        [Display(Name = "Language")]
        public string LanguageName { get; set; }

        public List<Language> Languages = new List<Language>();

        public bool IsValidForm()
        {
            return (!string.IsNullOrWhiteSpace(LanguageName));
        }
    }
}
