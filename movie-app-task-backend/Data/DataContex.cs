using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Data
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) :base(options)
        {
            
        }

        public DbSet<Media> Medias { get; set; }
        public DbSet<Actor> Actors { get; set; }
        
    }
}