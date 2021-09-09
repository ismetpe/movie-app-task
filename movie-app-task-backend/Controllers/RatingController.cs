using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : ControllerBase
    {
          private readonly DataContex _contex;
        public RatingController(DataContex contex)
        {
             _contex = contex;
           
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatings(){
            return  await _contex.Ratings.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Rating>> GetRating(int id){
             return await _contex.Ratings.FindAsync(id);
        }
    }
}