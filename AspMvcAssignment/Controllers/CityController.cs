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
            return RedirectToAction("Index");
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

            //var cityToRemove = _context.Cities.Find(cityId);

            //if (cityToRemove != null)
            //{
            //    _context.Cities.Remove(cityToRemove);
            //    _context.SaveChanges();
            //}
            //return RedirectToAction("Index");
        }

    }
}
