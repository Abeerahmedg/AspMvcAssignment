using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspMvcAssignment.Controllers
{
    public class CityController : Controller
    {
        readonly ApplicationDbContext _context;
        public CityViewModel cityView = new CityViewModel();
        public CityController(ApplicationDbContext context)

        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.CountryNames = new SelectList(_context.Countries, "CountryId", "CountryName");
            cityView.Cities = _context.Cities.Include(x=> x.Country).ToList();
            return View(cityView);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CityViewModel cvm)
        {


            City city = new City();
            ModelState.Remove("Country");
            ModelState.Remove("CityId");
            if (ModelState.IsValid)
            {
                city = new City() { CityName = cvm.CityName, CountryId = cvm.CountryId };
                _context.Cities.Add(city);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                cvm.Cities = _context.Cities.ToList();
                return View("Index", cvm);
            }
            //return RedirectToAction("Index");
        }


            public IActionResult Delete(int cityId)
        {
           
            City city = _context.Cities.Find(cityId);


            if (city != null)
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }


            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            City city = _context.Cities.Find(id);
            CityViewModel cityViewModel = new CityViewModel();

            cityViewModel.CityName = city.CityName;
            cityViewModel.CityId = id;
            cityViewModel.CountryId = city.CountryId;

            ViewBag.Countries = new SelectList(_context.Countries, "CountryId", "CountryName");

            return View(cityViewModel);
        }

        [HttpPost]
        public IActionResult Edit(CityViewModel cityViewModel)
        {
            City city = _context.Cities.Find(cityViewModel.CityId);

            if (ModelState.IsValid)
            {
                city.CityName = cityViewModel.CityName;
                city.CountryId = cityViewModel.CountryId;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //public IActionResult Edit (string id)
        //{
        //    var cvm = new CityViewModel();
        //    int cityId = int.Parse(id);
        //    City city = _context.Cities.Find(cityId);

        //    cvm.CityName = city.CityName;
        //    cvm.CityId = city.CityId;
        //    cvm.CountryId = city.CountryId;
        //    cvm.Country = city.Country;

        //    var countries = _context.Countries;
        //    //ViewBag.CountriesList = new SelectList(countries, "CountryId", "CountryName");

        //    return View(cvm);
        //}

        //[HttpPost]
        //public IActionResult Edit(CityViewModel cityViewModel)
        //{
        //    int cityId = cityViewModel.CityId;
        //    City city = _context.Cities.Find(cityId);

        //    if (ModelState.IsValid)
        //    {
        //        city.CityId = cityViewModel.CityId;
        //        city.CityName = cityViewModel.CityName;
        //        city.CountryId = cityViewModel.CountryId;
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(city);
        //    }


        //}


    }
}
