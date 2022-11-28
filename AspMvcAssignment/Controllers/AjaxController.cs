//using AspMvcAssignment.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using AspMvcAssignment.Models;

//namespace AspMvcAssignment.Controllers
//{
//    public class AjaxController : Controller
//    {
//        PeopleViewModel pvm = new();
//        public IActionResult Index()
//        {
//            pvm.tempList = pvm.PeopleList;
//            return View(pvm);
//        }
//        [HttpPost]
//        public IActionResult GetDetails(int id)
//        {
//            //Person person = PeopleViewModel.PeopleList.FirstOrDefault(i => i.Id == id);
//            //if (person == null)
//            //{
//            //    return Json("The writer name was not found!");
//            //}
//            //return PartialView("_PeoplePartial", person);
//            PeopleViewModel pvm = new();
//            foreach (Person person in pvm.PeopleList)
//            {
//                if (person.Id == id)
//                {
//                    pvm.tempList.Add(person);
//                    return PartialView("_PersonPartial", pvm);
//                }
//            }
//            pvm.tempList = pvm.PeopleList;
//            return Json("The writer name was not found!");
//        }

//        [HttpPost]
//        public IActionResult Delete(int id)
//        {
//            foreach (Person person in pvm.PeopleList)
//            {
//                if (person.Id == id)
//                {
//                    pvm.PeopleList.Remove(person);
//                    return Json(id + " was Succefully deleted");
//                }
//            }
//            return Json("Could not delete it!");
//        }
//        [HttpGet]
//        public IActionResult CreatePeople()
//        {
//            PeopleViewModel pvm = new();
//            pvm.tempList = pvm.PeopleList;

//            return PartialView("_PeoplePartial", pvm);
//        }
//    }
//}
