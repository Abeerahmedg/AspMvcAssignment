using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    public class PeopleDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public PeopleDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.People.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel person)
        {
           // ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                Person createPerson = new Person(Guid.NewGuid().ToString(), person.Name, person.NumberOfBooks, person.City);
                _context.People.Add(createPerson);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            if(id != null)
            {
                Person person = _context.People.Find(id);
                if (person != null)
                {
                    _context.People.Remove(person);
                    _context.SaveChanges();
                }
                
            }
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult Index(string search)
        //{
            

        //    if (search != null || search.Trim()== "")
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    foreach (Person person in _context.People)
        //    {
        //        if(person.Name.Contains(search) || person.City.Contains(search))
        //        {
        //            _context.People.Add(person);
        //        }
        //    }
        //    return View(_context);
        //}

    }
}
