using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AspMvcAssignment.Controllers
{
    public class PersonLanguageController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonLanguageViewModel plvm = new PersonLanguageViewModel();

        public PersonLanguageController(ApplicationDbContext aspMvcDbContext)
        {
            _context = aspMvcDbContext;
        }

        public IActionResult Index()
        {
            //ViewBag.Languages = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            //plvm.Languages = _context.Languages.Include(x => x.PersonLanguages).ToList();
            plvm.People = _context.People.ToList();
            plvm.Languages = _context.Languages.ToList();
            //plvm.PersonLanguages = _context.Languages.ToList();
            return View(plvm);
        }

        public IActionResult AddLanguageToPerson()
        {
            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            ViewBag.Languages = new SelectList(_context.Languages, "Id", "Id");
            return View();
        }
        [HttpPost]
        public IActionResult AddLanguageToPerson(int LanguageId, int id)
        {
           var person = _context.People.Include(x =>x.Languages).FirstOrDefault(x => x.Id == id);
            var language = _context.Languages.Find(LanguageId);

            if(person.Languages.Any(l=> l.LanguageId == language.LanguageId))
            {
                person.Languages.Add(language);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.People, "Id", "Name");
                ViewBag.Languages = new SelectList(_context.Languages.Where(x => x.LanguageId != LanguageId), "LanguageId", "LanguageId");
                ViewBag.Message = $"You already have this language: {language.LanguageId}!";
                return View();
            }

            return RedirectToAction("Index", new {id = id});


            //PersonLanguage personLanguage = new PersonLanguage();
            //ModelState.Remove("Id");
            //ModelState.Remove("LanguageId");
            //if (ModelState.IsValid)
            //{
               
            //    _context.PersonLanguages.Add(personLanguage);
            //    _context.SaveChanges();
            //    return RedirectToAction("Index");

            //}
            //else
            //{
            //    plvm.PersonLanguages = _context.PersonLanguages.ToList();
            //    return View("Index", plvm);
            //}
            //return RedirectToAction("Index");
        }
   

      

        [HttpGet]
        public IActionResult DeleteLanguageFromPerson(int id, int languageId)
        {
            //var lang = _context.Languages.Include(g => g.PersonLanguages).Single(u => u.LanguageId == languageId);
            //var pers = _context.People.Single(u => u.Id == id);
             var person= _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id==id);
            var languageToRemove = _context.Languages.Find(languageId);
            person.Languages.Remove(languageToRemove);

            //lang.PersonLanguages.Remove(lang.PersonLanguages.Where(ugu => ugu.Id == pers.Id).FirstOrDefault());
            _context.SaveChanges();



            return RedirectToAction("Index", new {id = id});
        }
    }
}



