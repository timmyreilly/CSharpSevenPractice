using System.Collections.Generic;
using WebAppOne.Models;

namespace WebAppOne.Services
{
    public class EntertainmentServiceDefault : IEntertainmentService
    {
        public IEnumerable<Game> GetGames()
        {
            return new List<Game>()
            {
                new Game() { Title = "RL", Genre = "Sport"},
                new Game() { Title = "Halo", Genre = "FPS"},
                new Game() { Title = "Sonic", Genre = "Platformer"}
            };
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
               new Movie() { Title = "Star War", Rating = 4},
               new Movie() { Title = "Anchorman" , Rating = 4}
            };
        }
    }
}