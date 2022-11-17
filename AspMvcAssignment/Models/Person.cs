using System.ComponentModel.DataAnnotations;

namespace AspMvcAssignment.Models
{
    public class Person
    {
        public string Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [Display(Name= "Number of books")]
        public int NumberOfBooks { get; set; }
        
        [Required]
        public string City { get; set; }

        public Person (string id, string name, int numberOfBooks, string city)
        {
            Id = id;
            Name = name;
            NumberOfBooks = numberOfBooks;
            City = city;
        }
    }
}
