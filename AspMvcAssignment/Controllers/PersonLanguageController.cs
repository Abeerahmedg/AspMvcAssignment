using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            plvm.PersonLanguages = _context.PersonLanguages.ToList();
            return View(plvm);
        }
        [HttpPost]
        public IActionResult AddLanguage()
        {
            PersonLanguage personLanguage = new PersonLanguage();
            ModelState.Remove("Id");
            ModelState.Remove("LanguageId");
            if (ModelState.IsValid)
            {
               
                _context.PersonLanguages.Add(personLanguage);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                plvm.PersonLanguages = _context.PersonLanguages.ToList();
                return View("Index", plvm);
            }
            return RedirectToAction("Index");
        }
   

      

        [HttpGet]
        public IActionResult Delete(int id, int languageId)
        {
            var lang = _context.Languages.Include(g => g.PersonLanguages).Single(u => u.LanguageId == languageId);
            var pers = _context.People.Single(u => u.Id == id);



            lang.PersonLanguages.Remove(lang.PersonLanguages.Where(ugu => ugu.Id == pers.Id).FirstOrDefault());
            _context.SaveChanges();



            return RedirectToAction("Index");
        }
    }
}



