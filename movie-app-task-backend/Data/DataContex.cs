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
        public DbSet<Rating> Ratings { get; set; }



           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              modelBuilder.Entity<Media>().HasData(
                //movies
                new Media 
                { 
                    Id = 1,
                     Title = "Thor",
                     Release_year = "2000",
                    Description = "The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth), where he soon becomes one of their finest defenders.", 
                    img_url= "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", 
                    isSeries=false, 
                    
                }
              );

              modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Chris Hemsworth"},
                new Actor { Id = 2, Name = "Natalie Portman"},
                new Actor { Id = 3, Name = "Tom Hiddleston"}
                );
          }
    }
}