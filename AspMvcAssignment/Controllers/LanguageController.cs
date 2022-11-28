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
            ViewBag.LanguagNames = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            languageView.Languages = _context.Languages.Include(x=>x.Languages).ToList();
            return View(languageView);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
       
        public IActionResult Create(LanguageViewModel languageViewModel)
        {
            if (!languageViewModel.IsValidForm())
                return View(languageViewModel);

            if (ModelState.IsValid)
            {
                Language language = new Language();
                language.LanguageName = languageViewModel.LanguageName;

                _context.Languages.Add(language);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index), "Person");
            }
            return View(languageViewModel);
        }

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

