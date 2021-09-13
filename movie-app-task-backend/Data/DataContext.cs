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
                  Title = "Star Wars: Return of the Jedi",
                  Release_year = "1983-05-25",
                  Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
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

                              },                              new Media
                              {
                                  Id = 6,
                                  Title = "Lord Of The Rings: The Return Of The King",
                                  Release_year = "2013-09-17",
                                  Description = "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 7,
                                  Title = "The Hobbit: An Unexpected Journey",
                                  Release_year = "2013-09-17",
                                  Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 8,
                                  Title = "The Hobbit: The Desolation of Smaug",
                                  Release_year = "2013-12-12",
                                  Description = "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 9,
                                  Title = "The Hobbit: The Battle of the Five Armies",
                                  Release_year = "2014-12-11",
                                  Description = "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 10,
                                  Title = "Rick and Morty",
                                  Release_year = "2013-09-17",
                                  Description = "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 11,
                                  Title = "The Walking Dead",
                                  Release_year = "2010-10-31",
                                  Description = "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 12,
                                  Title = "Star Trek: Discovery",
                                  Release_year = "2017-09-24",
                                  Description = "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 13,
                                  Title = "Yellowstone",
                                  Release_year = "2018-06-20",
                                  Description = "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 14,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 15,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 16,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 17,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 18,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 19,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 20,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 21,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 22,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 23,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 24,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 25,
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
                new Rating { Id = 4, Rating_value = 4.5F, MediaId = 4},
                new Rating { Id = 5, Rating_value = 4.6F, MediaId = 5},
                new Rating { Id = 6, Rating_value = 4.5F, MediaId = 6 },
                new Rating { Id = 7, Rating_value = 4.5F, MediaId = 7 },
                new Rating { Id = 8, Rating_value = 4.5F, MediaId = 8},
                                
                new Rating { Id = 9, Rating_value = 4.6F, MediaId = 9},
                new Rating { Id = 10, Rating_value = 4.5F, MediaId = 10 },
                new Rating { Id = 11, Rating_value = 4.5F, MediaId = 11 },
                new Rating { Id = 12, Rating_value = 4.5F, MediaId = 12},
                new Rating { Id = 13, Rating_value = 4.6F, MediaId = 13},
                new Rating { Id = 14, Rating_value = 4.5F, MediaId = 14 },
                new Rating { Id = 15, Rating_value = 4.5F, MediaId = 15 },
                new Rating { Id = 16, Rating_value = 4.5F, MediaId = 16},



                new Rating { Id = 17, Rating_value = 4.6F, MediaId = 17},
                new Rating { Id = 18, Rating_value = 4.5F, MediaId = 18},
                new Rating { Id = 19, Rating_value = 4.5F, MediaId = 19},
                new Rating { Id = 20, Rating_value = 4.5F, MediaId = 20},
                new Rating { Id = 21, Rating_value = 4.6F, MediaId = 21},
                new Rating { Id = 22, Rating_value = 4.5F, MediaId = 22},
                new Rating { Id = 23, Rating_value = 4.5F, MediaId = 23},
                new Rating { Id = 24, Rating_value = 4.5F, MediaId = 24}
            
            );
          
        }
    }
}