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

      public int LanguageId { get; set; }
        public int Id { get; set; }

       
    }
}
