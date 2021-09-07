using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

        public ActionResult<IEnumerable<Media>> GetMedias(){
           return _contex.Medias.ToList();
        }


        [HttpGet("{id}")]

        public ActionResult<Media> GetMedia(int id){
            return _contex.Medias.Find(id);
        }
    }
}