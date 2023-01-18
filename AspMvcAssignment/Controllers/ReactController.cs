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
    //public class ReactController : ControllerBase
    //{
    //    readonly ApplicationDbContext _context;

    //    public ReactController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }
    //    [HttpGet]
    //    public List<Person> GetPeople()
    //    {
    //        List<Person> people = new List<Person>();
    //        people = _context.People.ToList();
    //        return people;
    //    }
    //    [HttpDelete("{id}")]
    //    public IActionResult Delete(int id)
    //    {
    //        var person = _context.People.Find(id);

    //        if (person != null)
    //        {
    //            _context.People.Remove(person);
    //            _context.SaveChanges();

    //            return StatusCode(200);
    //        }
    //        return StatusCode(404);
    //    }
    //    [HttpPost("create")]
    //    public IActionResult Create(JsonObject personJson)
    //    {
    //        string jsonPerson = personJson.ToString();

    //        ReactPerson personToCreate = JsonConvert.DeserializeObject<ReactPerson>(jsonPerson);

    //        if (personToCreate != null)
    //        {
    //            _context.People.Add(new Person { Name = personToCreate.Name, NumberOfBooks = personToCreate.NumberOfBooks, CityId=personToCreate.City });
    //            _context.SaveChanges();

    //            return StatusCode(200);
    //        }
    //        return StatusCode(404);
    //    }
    //    [HttpGet("cities")]
    //    public List<City> GetCities()
    //    {
    //        var city = _context.Cities.ToList();
    //        return city;
    //    }
    //    [HttpGet("cities/{id}")]
    //    public List<City> GetCities(int id)
    //    {
    //        return _context.Cities.Where(x => x.CountryId == id).ToList();
    //    }
    //    [HttpGet("countries")]
    //    public List<Country> GetCountries()
    //    {
    //        var country = _context.Countries.ToList();
    //        return country;
    //    }

    //    [HttpGet("countries")]
    //    public List<Country> GetCountries(int id)
    //    {
    //        return _context.Countries.Include(y => y.Cities).ToList();
    //    }
    //}

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

        [HttpGet("{id}")]
        public async Task<ReactPerson> GetPersonDetails(int id)
        {
            Person person = await _context.People.Include(p => p.City).Include(l => l.Languages).FirstOrDefaultAsync(x => x.Id == id);
            City cityFromId = await _context.Cities.FirstOrDefaultAsync(c => c.CityId == person.CityId);

            List<string> languages = new List<string>();

            foreach (var language in person.Languages)
            {
                languages.Add(language.LanguageName);
            }

            ReactPerson reactPerson = new();

            if (cityFromId != null)
            {
                reactPerson.City = cityFromId.CityName;
                reactPerson.Country = _context.Countries.FirstOrDefault(x => x.CountryId == cityFromId.CountryId).CountryName;
                reactPerson.CountryId = cityFromId.CountryId;
                reactPerson.Languages = languages;
            }

            reactPerson.Languages = languages;

            return reactPerson;
        }

        [HttpGet("countries")]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountry()
        {
            return await _context.Countries.ToListAsync();
        }

        [HttpGet("cities")]
        public async Task<ActionResult<IEnumerable<City>>> GetCity(int CountryId)
        {
            return await _context.Cities.Where(s => s.CountryId == CountryId).ToListAsync();
        }

        [HttpGet("languages")]
        public async Task<ActionResult<IEnumerable<Language>>> GetLanguage()
        {
            return await _context.Languages.ToListAsync();
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
        public IActionResult Create(JsonObject person)
        {
            string jsonPerson = person.ToString();

            Person personToCreate = JsonConvert.DeserializeObject<Person>(jsonPerson);

            if (personToCreate != null)
            {
                
                _context.People.Add(personToCreate);
                _context.SaveChanges();

                return StatusCode(200);
            }

            return StatusCode(404);
        }
        //[HttpGet("{id}")]
        //public async Task<ReactPerson> GetPersonDetails(int id)
        //{
        //    Person person = await _context.People.Include(p => p.City).Include(l => l.Languages).FirstOrDefaultAsync(x => x.Id == id);
        //    City cityFromId = await _context.Cities.FirstOrDefaultAsync(c => c.CityId == person.CityId) ?? new City();

        //    List<string> languages = new List<string>();

        //    foreach (var language in person.Languages)
        //    {
        //        languages.Add(language.LanguageName);
        //    }

        //    if (cityFromId == null)
        //    {
        //        return new ReactPerson
        //        {
        //            Id = 0,
        //            Name = "City not found",
        //            NumberOfBooks = 0,
        //            City = "",
        //            Country = "",
        //            Languages = null
        //        };
        //    }
        //    else
        //    {
        //        return new ReactPerson
        //        {
        //            Id = person.Id,
        //            Name = person.Name,
        //            NumberOfBooks = person.NumberOfBooks,
        //            City = cityFromId.CityName,
        //            Country = cityFromId.Country.CountryName,
        //            Languages = languages
        //        };
        //    }
        //}
    }
}

