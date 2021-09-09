using System.Collections.Generic;

namespace movie_app_task_backend.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public bool isSeries { get; set;}
        public Rating Rating { get; set; }
        public ICollection<Actor> Actor { get; set;}
        public int ActorId { get; set; }
    }
}