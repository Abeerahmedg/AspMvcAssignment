using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspMvcAssignment.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LanguageViewModel languageView = new LanguageViewModel();

        public LanguageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            peopleViewModel.People = _context.People.Include(x => x.Languages).ToList();

            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            ViewBag.Languages = new SelectList(_context.Languages, "LanguageId", "LanguageName");

            return View(peopleViewModel);
        }

        [HttpPost]
        public IActionResult AddLanguage(LanguageViewModel vm)
        {

            if (ModelState.IsValid)
            {
                Language language = new Language() { LanguageName = vm.LanguageName };
                _context.Add(language);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddLanguageToPerson(LanguageViewModel vm)
        {
            Person person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == vm.Id);
            Language language = _context.Languages.Find(vm.LanguageId);

            person.Languages.Add(language);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int LanguageId , int id)
        {
            var person = _context.People.Include(x=>x.Languages).FirstOrDefault(x => x.Id == id);
            var deleteLanguage = _context.Languages.Find(LanguageId);
            if (deleteLanguage != null)
            {
                _context.Languages.Remove(deleteLanguage);
                _context.SaveChanges();
            }

            return View("Index", new {id = id});
        }
        [HttpPost]
        public IActionResult Details(int id)
        {
           
            return View("Index");
        }

        //    ViewBag.LanguagNames = new SelectList(_context.Languages, "LanguageId", "LanguageName");
        //    languageView.Languages = _context.Languages.Include(x=>x.Languages).ToList();
        //    return View(languageView);
        //}

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]

        //public IActionResult Create(LanguageViewModel languageViewModel)
        //{
        //    if (!languageViewModel.IsValidForm())
        //        return View(languageViewModel);

        //    if (ModelState.IsValid)
        //    {
        //        Language language = new();
        //        language.LanguageName = languageViewModel.LanguageName;

        //        _context.Languages.Add(language);
        //        _context.SaveChanges();
        //        return RedirectToAction(nameof(Index), "Person");
        //    }
        //    return View(languageViewModel);
        //}

        [HttpGet]
        public IActionResult Delete(int LanguageId)
        {
            var deleteLanguage = _context.Languages.Find(LanguageId);
            if (deleteLanguage != null)
            {
                _context.Languages.Remove(deleteLanguage);
                _context.SaveChanges();
            }

            return View("Index");
        }
    }
}



