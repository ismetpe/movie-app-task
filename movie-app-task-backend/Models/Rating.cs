

using System;

namespace movie_app_task_backend.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int NumberOfRatings { get; set; }
        public int SumOfRatings { get; set; }
        
        public int MediaId { get; set; }
        public Media Media { get; set; }

  
    }
}