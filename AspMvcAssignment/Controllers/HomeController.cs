using System.Reflection;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (PeopleViewModel.PeopleList.Count == 0)
            { 
                PeopleViewModel.FillPeople();

            }
                PeopleViewModel pvm = new PeopleViewModel();
                pvm.tempList = PeopleViewModel.PeopleList;
            
            return View(pvm);
        }
        
        public IActionResult Delete(string id)
        {
            Person person = PeopleViewModel.PeopleList.FirstOrDefault(s => s.Id == id);
          
            PeopleViewModel.PeopleList.Remove(person);

            return RedirectToAction("Index");

        }

        [HttpPost]
     public IActionResult CreatePerson(CreatePersonViewModel createPerson)
        {
            
            if (ModelState.IsValid)
            {
                Person person = new Person(Guid.NewGuid().ToString(), createPerson.Name, createPerson.NumberOfBooks, createPerson.City);
                PeopleViewModel.PeopleList.Add(person);
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            PeopleViewModel pvm = new();
            if (search == null || search.Trim() == "")
            {
                return RedirectToAction("Index");
            }
            foreach (Person person in PeopleViewModel.PeopleList)
            {
                if (person.Name.Contains(search) || person.City.Contains(search))
                {
                    pvm.tempList.Add(person);
                }
            }
            return View(pvm);
        }

    }
}
