using System.Collections.Generic;
using WebAppOne.Models;

namespace WebAppOne.Services
{
    public interface IEntertainmentService
    {
         IEnumerable<Movie> GetMovies();
         IEnumerable<Game> GetGames();  
    }
}