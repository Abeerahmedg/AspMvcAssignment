using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
            cityView.Cities = _context.Cities.Include(x=> x.Country).ToList();
            return View(cityView);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int cityId)
        {
            var cityToRemove = _context.Cities.Find(cityId);

            if (cityToRemove != null)
            {
                _context.Cities.Remove(cityToRemove);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
