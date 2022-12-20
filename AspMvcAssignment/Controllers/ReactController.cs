using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Nodes;


namespace AspMvcAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people = _context.People.ToList();
            return people;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = _context.People.Find(id);

            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();

                return StatusCode(200);
            }
            return StatusCode(404);
        }
        [HttpPost("create")]
        public IActionResult Create(JsonObject personJson)
        {
            string jsonPerson = personJson.ToString();

            ReactPerson personToCreate = JsonConvert.DeserializeObject<ReactPerson>(jsonPerson);

            if (personToCreate != null)
            {
                _context.People.Add(new Person { Name = personToCreate.Name, NumberOfBooks = personToCreate.NumberOfBooks, CityId=personToCreate.City });
                _context.SaveChanges();

                return StatusCode(200);
            }
            return StatusCode(404);
        }
        [HttpGet("cities")]
        public List<City> GetCities()
        {
            var city = _context.Cities.ToList();
            return city;
        }
        [HttpGet("cities/{id}")]
        public List<City> GetCities(int id)
        {
            return _context.Cities.Where(x => x.CountryId == id).ToList();
        }
        [HttpGet("countries")]
        public List<Country> GetCountries()
        {
            var country = _context.Countries.ToList();
            return country;
        }

        [HttpGet("countries")]
        public List<Country> GetCountries(int id)
        {
            return _context.Countries.Include(y => y.Cities).ToList();
        }

    }
}
