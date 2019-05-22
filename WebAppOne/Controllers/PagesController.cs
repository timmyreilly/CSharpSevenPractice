using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppOne.Models;
using WebAppOne.Services;

namespace WebAppOne.Controllers
{

    [Route("mypages")]
    public class PagesController : Controller
    {
        private readonly IEntertainmentService _service; 

        // The service will be injected to the constructor by the container. 
        // The control is reversed and provided by the container. 
        public PagesController(IEntertainmentService service)
        {
            _service = service; 
        }

        // [Route("mygames")]
        // public IActionResult Games()
        // {
        //     ViewData["games"] = new List<Game>()
        //     {
        //         new Game() { Title = "RL", Genre = "Sport"},
        //         new Game() { Title = "Halo", Genre = "FPS"},
        //         new Game() { Title = "Sonic", Genre = "Platformer"}
        //     };
        //     return View();
        // }

        // [Route("mymovies")]
        // public IActionResult Movies()
        // {
        //     var movies = new List<Movie>()
        //     {
        //        new Movie() { Title = "Star War", Rating = 4},
        //        new Movie() { Title = "Anchorman" , Rating = 4}
        //     };
        //     return View(movies);
        // }

        [Route("mygames", Name="MyGames")]
        public IActionResult Games() 
        {
            ViewData["games"] = _service.GetGames(); 
            return View(); 
        }

        [Route("mymovies", Name="MyMovies")]
        public IActionResult Movies() 
        {
            var movies = _service.GetMovies(); 
            return View(movies); 
        }

        // Attribute Routing: 
        [Route("mygamesBad")]
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