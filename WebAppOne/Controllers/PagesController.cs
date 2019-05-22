using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppOne.Models;

namespace WebAppOne.Controllers
{

    [Route("mypages")]
    public class PagesController : Controller
    {
        public IActionResult Games()
        {
            ViewData["games"] = new List<Game>()
            {
                new Game() { Title = "RL", Genre = "Sport"},
                new Game() { Title = "Halo", Genre = "FPS"},
                new Game() { Title = "Sonic", Genre = "Platformer"}
            };
            return View();
        }

        public IActionResult Movies()
        {
            var movies = new List<Movie>()
            {
               new Movie() { Title = "Star War", Rating = 4},
               new Movie() { Title = "Anchorman" , Rating = 4}
            };
            return View(movies);
        }

        // Attribute Routing: 
        [Route("mygames")]
        public IActionResult MoviesNoViewYet()
        {
            var movies = new List<Movie>()
            {
               new Movie() { Title = "Star War", Rating = 4},
               new Movie() { Title = "Anchorman" , Rating = 4}
            };
            return View(movies);
        }



    }
}