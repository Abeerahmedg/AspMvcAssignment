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
                CreatePersonViewModel.FillPeople();

            }
                PeopleViewModel pvm = new PeopleViewModel();
                pvm.tempList = PeopleViewModel.PeopleList;
            
            return View(pvm);
        }
        
        public IActionResult Delete(string id)
        {
            Person person = PeopleViewModel.PeopleList.FirstOrDefault(s => s.Id == id);
            if (person != null)
            {
                PeopleViewModel.PeopleList.Remove(person);

            }

            return RedirectToAction("Index");

        }

     public IActionResult CreatePerson(CreatePersonViewModel createPerson)
        {
            PeopleViewModel pvm = new PeopleViewModel();
            if (ModelState.IsValid)
            {
                pvm.CreatePerson(createPerson.Id,createPerson.Name, createPerson.NumberOfBooks, createPerson.City);
            }
            pvm.tempList= PeopleViewModel.PeopleList;
            return View("Index", pvm);
        }

    }
}
