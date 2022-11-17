using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
