using Microsoft.EntityFrameworkCore;
using WebAppOne.Models;

namespace WebAppOne.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }

    }
}