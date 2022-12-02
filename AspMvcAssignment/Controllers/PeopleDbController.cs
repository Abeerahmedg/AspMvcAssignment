using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspMvcAssignment.Controllers
{
    public class PeopleDbController : Controller
    {
        readonly ApplicationDbContext _context;
        public PeopleViewModel peopleModel { get; set; } = new PeopleViewModel();

        public PeopleDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        { 
            peopleModel.PeopleList = _context.People.Include(x => x.City.Country).ToList();
            ViewBag.Cities = new SelectList(_context.Cities, "CityId", "CityName");
           
            return View(peopleModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel cpvm)
        {
            // CreatePersonViewModel cpvm = new CreatePersonViewModel();
            Person person = new Person();
            ModelState.Remove("CityName");
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                person = new Person() { Name = cpvm.Name, NumberOfBooks = cpvm.NumberOfBooks, CityId = cpvm.CityId };
                _context.People.Add(person);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                peopleModel.PeopleList = _context.People.ToList();
                return View("Index", peopleModel);
            }
            //return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            int prsonId = int.Parse(id);
            Person person = _context.People.Find(prsonId);

           
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }


            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Search(string search)
        {


            if (String.IsNullOrEmpty(search))

            {
                return RedirectToAction("Index");
            }
            peopleModel.PeopleList = _context.People.Where(x => x.Name.Contains(search)).ToList();
            peopleModel.Search = search;
            return View("Index", peopleModel);
        }
        //[HttpGet]
        //public IActionResult ShowPerson(int personId)
        //{
        //    Person person = _context.People.Find(personId);
        //    if (person != null)
        //    {
        //        List<City> cities = _context.Cities.ToList();
        //        City city = cities.SingleOrDefault(ci => ci.CityId == person.CityId);
        //        ViewData["City"] = city.CityName;

        //        List<Country> countries = _context.Countries.ToList();
        //        ViewData["Country"] = countries.SingleOrDefault(co => co.CountryId == city.CountryId).CountryName;
        //    }
        //    return PartialView("~/Views/Shared/_PeopleDetailsPartial.cshtml", person);
        //}

        public IActionResult Edit(int id)
        {
            Person person = _context.People.Find(id);
            PersonViewModel personViewModel = new PersonViewModel();

            personViewModel.Id = id;
            personViewModel.Name = person.Name;
            personViewModel.NumberOfBooks = person.NumberOfBooks;
            personViewModel.CityId = person.CityId;

            ViewBag.Cities = new SelectList(_context.Cities, "CityId", "CityName");

            return View(personViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PersonViewModel personViewModel)
        {
            Person person = _context.People.Find(personViewModel.Id);

            if (ModelState.IsValid)
            {
                person.Name = personViewModel.Name;
                person.NumberOfBooks = personViewModel.NumberOfBooks;
                person.CityId = personViewModel.CityId;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
