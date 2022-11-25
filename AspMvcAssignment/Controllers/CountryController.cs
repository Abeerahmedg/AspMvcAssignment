using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspMvcAssignment.Controllers
{
    public class CountryController : Controller
    {
        readonly ApplicationDbContext _context;
        public CountryViewModel countryView = new CountryViewModel();
        public CountryController(ApplicationDbContext context)

        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.CityNames = new SelectList(_context.Cities, "CityId", "CityName");
            countryView.Countries = _context.Countries.Include(x => x.Cities).ToList();
            return View(countryView);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CountryViewModel cvm)
        {


            //Country country = new Country();
            ModelState.Remove("City");
            ModelState.Remove("CountryId");
            if (ModelState.IsValid)
            {
                Country country = new Country() { CountryName = cvm.CountryName };
                _context.Countries.Add(country);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                cvm.Countries = _context.Countries.ToList();
                return View("Index", cvm);
            }
        }


        public IActionResult Delete(int countryId)
        {

            Country country = _context.Countries.Find(countryId);


            if (country != null)
            {
                _context.Countries.Remove(country);
                _context.SaveChanges();
            }


            return RedirectToAction("Index");
        }
    }
}
