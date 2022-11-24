//using System.Reflection;
//using AspMvcAssignment.Models;
//using AspMvcAssignment.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace AspMvcAssignment.Controllers
//{
//    public class HomeController : Controller
//    {
//       static PeopleViewModel pvm = new PeopleViewModel();
//        public IActionResult Index()
//        {
//            if (pvm.PeopleList.Count == 0)
//            {
//                pvm.FillPeople();
//            }
          

//            return View(pvm);
//        }

//        public IActionResult Delete(int id)
//        {
//            Person person = pvm.PeopleList.FirstOrDefault(s => s.Id == id);

//            pvm.PeopleList.Remove(person);

//            return RedirectToAction("Index");

//        }

//        [HttpPost]
//        public IActionResult CreatePerson(PeopleViewModel peopleViewModel)
//        {

//            if (ModelState.IsValid)
//            {
//                Person createPerson = new Person( peopleViewModel.cpvm.Name, peopleViewModel.cpvm.NumberOfBooks, peopleViewModel.cpvm.City);
//                pvm.PeopleList.Add(createPerson);
//            } else
//            {
//                if (pvm.PeopleList.Count == 0)
//                {
//                    pvm.FillPeople();

//                }
//                //pvm.tempList = pvm.PeopleList;
//                return View("Index", pvm);
//            }

//            return RedirectToAction("Index");
//        }

      
//        [HttpPost]
//        public IActionResult Search(string search)
//        {


//            if (String.IsNullOrEmpty(search))

//            {
//                return RedirectToAction("Index");
//            }
           
//            pvm.PeopleList = pvm.PeopleList.Where(x => x.Name.Contains(search)).ToList();
//            pvm.Search = search;
//            return View("Index", pvm);
//        }

//    }
//}
