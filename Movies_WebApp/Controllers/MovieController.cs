using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_WebApp.Data;

namespace Movies_WebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;  //create db object

        public MovieController(ApplicationDbContext context)
        {
            _context = context;  //initialize db
        }

        public async Task<IActionResult> Index() //use asynchronous mechanism
        {
            var data = await _context.Movies.Include(m => m.Cinema).ToListAsync(); //get data and convert to list
            return View(data);
        }
    }
}
