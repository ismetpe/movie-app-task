using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MediasController : ControllerBase
    {
        private readonly DataContex _contex;
        public MediasController(DataContex contex)
        {
             _contex = contex;
           
        }


        [HttpGet]

        public async Task<ActionResult<IEnumerable<Media>>> GetMedias(){
            return  await _contex.Medias.ToListAsync();
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Media>> GetMedia(int id){
             return await _contex.Medias.FindAsync(id);
        }
    }
}