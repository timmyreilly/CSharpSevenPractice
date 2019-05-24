using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppOne.Models;

namespace WebAppOne.Services

{
    public interface ISongsService
    {
        Task CreateAsync(Song song);
        Task<IEnumerable<Song>> GetAllAsync(); 
        Task UpdateAsync(Song song); 
        Task DeleteAsync(int id);  
    }
}