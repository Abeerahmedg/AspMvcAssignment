using AspMvcAssignment.Data;
using AspMvcAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people = _context.People.ToList();
            return people;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = _context.People.Find(id);

            if(person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                return StatusCode(200);
            }
            return StatusCode(404);
        }
    }
}
