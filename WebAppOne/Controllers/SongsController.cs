using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppOne.Models;
using WebAppOne.Services;

namespace WebAppOne.Controllers 
{
    public class SongsController : Controller
    {
        private ISongsService _songsService; 

        public SongsController(ISongsService songsService) 
        {
            _songsService = songsService; 
        }

        [Route("songs/all")]
        public async Task<IActionResult> Index() 
        {
            return View(await _songsService.GetAllAsync()); 
        }

        [Route("songs/new")]
        public IActionResult NewSongForm()
        {
            return View("Form"); 
        }

        [Route("songs/add")]
        public async Task<IActionResult> Add(Song song) 
        {
            await _songsService.CreateAsync(song); 
            return RedirectToAction("Index"); 

        }
    }
}