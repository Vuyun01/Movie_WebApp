using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_WebApp.Data;
using Movies_WebApp.Data.Services;
using Movies_WebApp.Models;

namespace Movies_WebApp.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _service; //create db object

        public ActorController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index() //use asynchronous mechanism
        {
            var data = await _service.GetAllAsync(); //get data and convert to list
            return View(data);
        }
        
        //Get: Create view
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfileImageURL, FullName, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //GET: Detail view
        public async Task<IActionResult> Details(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
            {
                return View("NotFound");
            }
            return View(actor);
        }


        //GET: Edit view
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
            {
                return View("NotFound");
            }
            return View(actor);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ActorID, ProfileImageURL, FullName, Bio")] Actor actor)
        {
            if (id != actor.ActorID)
            {
                return View("NotFound");
            }
            else
            {

                if (ModelState.IsValid)
                {
                    await _service.UpdateAsync(actor);
                    return RedirectToAction(nameof(Index));
                }
                return View(actor);
            }
        }

        //GET: Delete view
        public async Task<IActionResult> Delete(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
            {
                return View("NotFound");
            }
            return View(actor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmation(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
