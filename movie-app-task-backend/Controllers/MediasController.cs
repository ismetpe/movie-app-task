using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
using movie_app_task_backend.Models;
using movie_app_task_backend.Services.MediaService;

namespace movie_app_task_backend.Controllers
{

    [ApiController]
    [Route("media")]
    public class MediasController : ControllerBase
    {
        private readonly IMediaService _mediaService;
        public MediasController(IMediaService mediaService)
        {
           _mediaService = mediaService;

        }


        [HttpGet("all_movies")]
        public async Task<ActionResult<IEnumerable<GetMediaDto>>> GetMedias()
        {
            return Ok(await _mediaService.GetAllMedia(false));
        }


    }
}