using movie_app_task_backend.Models;

namespace movie_app_task_backend.Dtos.Rating
{
    public class GetRatingDto
    {
        public int Id { get; set; }

        public int NumberOfRatings { get; set; } = 1;
        public int SumOfRatings { get; set; } = 1;
        
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}