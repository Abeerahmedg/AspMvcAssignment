using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    public class PeopleDbController : Controller
    {
        readonly ApplicationDbContext _context;
        public PeopleViewModel peopleModel { get; set; }= new PeopleViewModel();

        public PeopleDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            peopleModel.PeopleList = _context.People.ToList();
            return View(peopleModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PeopleViewModel peopleViewModel)
        {
            // ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                Person createPerson = new Person(Guid.NewGuid().ToString(), peopleViewModel.cpvm.Name, peopleViewModel.cpvm.NumberOfBooks, peopleViewModel.cpvm.City);
                _context.People.Add(createPerson);
                _context.SaveChanges();

            }
            else
            {
                peopleModel.PeopleList = _context.People.ToList();
                return View("Index",peopleModel);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            if (id != null)
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
        [HttpPost]
        public IActionResult Search(string search)
        {


            if (String.IsNullOrEmpty(search))
            
            {
                return RedirectToAction("Index");
            }
            //foreach (Person person in _context.People)
            //{
            //    if (person.Name.Contains(search) || person.City.Contains(search))
            //    {
            //        _context.People.Add(person);
            //    }
            //}
            peopleModel.PeopleList= _context.People.Where(x=>x.Name.Contains(search)).ToList();
            peopleModel.Search = search;
            return View("Index",peopleModel);
        }

    }
}
