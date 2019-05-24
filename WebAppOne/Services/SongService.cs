using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppOne.Data;
using WebAppOne.Models;
using AutoMapper; 

namespace WebAppOne.Services
{
    public class SongService : ISongsService
    {
        private AppDbContext _dbContext;

        public SongService(AppDbContext context)
        {
            _dbContext = context;
        }
        public async Task CreateAsync(Song song)
        {
            _dbContext.Songs.Add(song);
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var s = await findSong(id); 
            _dbContext.Songs.Remove(s); 
            await _dbContext.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<Song>> GetAllAsync()
        {

            return await _dbContext.Songs.ToListAsync();
        }

        public async Task UpdateAsync(Song song)
        {
            var s = findSong(song.Id); 
            await Mapper.Map(song, s); 
            _dbContext.Update(s); 
            await _dbContext.SaveChangesAsync(); 


        }

        private async Task<Song> findSong(int id) 
        {
            var song = await _dbContext.Songs.SingleOrDefaultAsync(s => s.Id == id); 
            if(song == null)
            {
                throw new ArgumentException("Song does not exist"); 
            }
            return song; 
        }
    }
}