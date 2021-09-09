using System.Collections.Generic;
using movie_app_task_backend.Dtos.Actor;
using movie_app_task_backend.Dtos.Rating;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Dtos
{
    public class GetMediaDto
    {
         public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public bool isSeries { get; set;}
        public GetRatingDto Rating { get; set; }
        public ICollection<GetActorDto> Actor { get; set;}
    }
}