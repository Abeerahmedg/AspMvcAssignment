using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AspMvcAssignment.Models;

namespace AspMvcAssignment.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            PeopleViewModel pvm = new();
            pvm.tempList = PeopleViewModel.PeopleList;
            return View(pvm);
        }
        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            Person person = PeopleViewModel.PeopleList.FirstOrDefault(i => i.Id == id);
            if (person == null)
            {
                return Json("The writer name was not found!");
            }
            return PartialView("_PeoplePartial", person);
          /*  PeopleViewModel pvm = new();
            foreach (Person person in PeopleViewModel.PeopleList)
            {
                if (person.Id == id.Trim())
                {
                    pvm.tempList.Add(person);
                    return PartialView("_PeopleDetailsPartial", pvm);
                }
            }
            pvm.tempList = PeopleViewModel.PeopleList;
            return PartialView("_PeopleDetailsPartial", pvm);*/
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            foreach (Person person in PeopleViewModel.PeopleList)
            {
                if (person.Id == id)
                {
                    PeopleViewModel.PeopleList.Remove(person);
                    return Json(id + " was Succefully deleted");
                }
            }
            return Json("Could not delete it!");
        }
        [HttpGet]
        public IActionResult CreatePeople()
        {
            PeopleViewModel pvm = new();
            pvm.tempList = PeopleViewModel.PeopleList;
   
            return PartialView("_PeoplePartial",pvm);
        }
    }
}
