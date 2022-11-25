﻿using AspMvcAssignment.Data;
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
            ViewBag.CityNames = new SelectList(_context.Cities, "CityId", "CityName");
            peopleModel.PeopleList = _context.People.Include(x => x.City).ToList();
            return View(peopleModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PeopleViewModel m)
        {
            CreatePersonViewModel cpvm = new CreatePersonViewModel();
            ModelState.Remove("CityName");
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                var addPerson = new Person() { Name = m.cpvm.Name, NumberOfBooks = m.cpvm.NumberOfBooks, CityId = m.cpvm.CityId };
                _context.People.Add(addPerson);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                peopleModel.PeopleList = _context.People.ToList();
                return View("Index", peopleModel);
            }
            return RedirectToAction("Index");
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
        [HttpGet]
        public IActionResult ShowPerson(int personId)
        {
            Person person = _context.People.Find(personId);
            if (person != null)
            {
                List<City> cities = _context.Cities.ToList();
                City city = cities.SingleOrDefault(ci => ci.CityId == person.CityId);
                ViewData["City"] = city.CityName;

                List<Country> countries = _context.Countries.ToList();
                ViewData["Country"] = countries.SingleOrDefault(co => co.CountryId == city.CountryId).CountryName;
            }
            return PartialView("~/Views/Shared/_PeopleDetailsPartial.cshtml", person);
        }

    }
}
