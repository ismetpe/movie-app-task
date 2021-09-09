using System.Collections.Generic;
using System.Threading.Tasks;
using movie_app_task_backend.Dtos;

namespace movie_app_task_backend.Services.MediaService
{
    public interface IMediaService
    {
        Task<List<GetMediaDto>> GetAllMedia(bool isSeries);
    }
}