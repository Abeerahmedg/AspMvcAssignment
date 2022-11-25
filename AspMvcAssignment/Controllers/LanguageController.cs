using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using AspMvcAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            languageView.Languages = _context.Languages.ToList();
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
        public IActionResult Delete(int id)
        {
            var deleteLanguage = _context.Languages.FirstOrDefault(l => l.LanguageId == id);
            if (deleteLanguage == null)
            {
                ViewData["Message"] = "Failed to delete language!";
                return View(_context.Languages.ToList());
            }

            try
            {
                _context.Languages.Remove(deleteLanguage);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index), "Person");
            }
            catch
            {
                ViewData["Message"] = $"Failed to delete {deleteLanguage.LanguageName}!";
            }
            return View(_context.Languages.ToList());
        }
    }

}

