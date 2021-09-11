using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Media> Medias { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Rating> Ratings { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Media>().HasData(

              new Media
              {
                  Id = 1,
                  Title = "Thor",
                  Release_year = "2000-05-14",
                  Description = "The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth), where he soon becomes one of their finest defenders.",
                  img_url = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                  isSeries = false,

              },
                              new Media
                              {
                                  Id = 2,
                                  Title = "Star Wars: A New Hope",
                                  Release_year = "1977-05-17",
                                  Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 3,
                                  Title = "Lord Of The Rings: The Two Towers",
                                  Release_year = "2002-12-18",
                                  Description = "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 4,
                                  Title = "The Hobbit: An Unexpected Journey",
                                  Release_year = "2012-12-13",
                                  Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 5,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              }


            );
             

            modelBuilder.Entity<Actor>().HasData(
              new Actor { Id = 1, Name = "Chris Hemsworth"},
              new Actor { Id = 2, Name = "Natalie Portman" },
              new Actor { Id = 3, Name = "Tom Hiddleston" },
 new Actor     {
         Id = 4,
         Name = "Brianna Howe"
      },
 new Actor     {
         Id = 5,
        Name = "Carver Wong"
      },
 new Actor     {
         Id = 6,
        Name= "James Hines"
      },
 new Actor     {
         Id = 7,
         Name = "Leon Jarvis"
      },
  new Actor    {
         Id = 8,
         Name = "Vinson Moran"
      },
  new Actor    {
         Id = 9,
         Name = "Simpson Evans"
      },
 new Actor     {
        Id =10,
         Name = "Henry Molina"
      },
 new Actor     {
         Id = 11,
        Name = "Mccullough Curry"
      },
  new Actor    {
         Id = 12,
         Name = "Angelia Ruiz"
      },
   new Actor   {
         Id = 13,
         Name = "Hinton Love"
      },
  new Actor    {
        Id = 14,
         Name = "Victoria Alston"
      }
              );




                         
            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Rating_value = 4.6F, MediaId = 1},
                new Rating { Id = 2, Rating_value = 4.5F, MediaId = 2 },
                new Rating { Id = 3, Rating_value = 4.5F, MediaId = 3 },
                new Rating { Id = 4, Rating_value = 4.5F, MediaId = 4}
            
            );
          
        }
    }
}