namespace AspMvcAssignment.Models
{
    public class ReactPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfBooks { get; set; }
        public int CityId { get; set; }

        public string City { get; set; }

        public int? CountryId { get; set; }

        public string Country { get; set; }

        public List<string> Languages { get; set; }

    }
}
