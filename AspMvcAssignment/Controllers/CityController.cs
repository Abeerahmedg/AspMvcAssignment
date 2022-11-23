using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    public class CityController : Controller
    {
        readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)

        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(/*_context.Cities.ToList()*/);
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(City city)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Cities.Add(city);
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Delete(string cityId)
        //{
        //    var cityToRemove = _context.Cities.Find(cityId);

        //    if(cityToRemove != null)
        //    {
        //        _context.Cities.Remove(cityToRemove);
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}

    }
}
