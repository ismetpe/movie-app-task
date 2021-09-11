using System.Threading.Tasks;
using movie_app_task_backend.Dtos.Rating;

namespace movie_app_task_backend.Services.RatingService
{
    public interface IRatingService
    {
        Task<bool> AddRating(float rating, int MediaId);
    }
}