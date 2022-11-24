using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
