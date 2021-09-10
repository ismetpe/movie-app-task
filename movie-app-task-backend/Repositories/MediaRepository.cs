using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;

namespace movie_app_task_backend.Repositories
{
    public class MediaRepository
    {

        private readonly IMapper _mapper;
        private readonly DataContex _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MediaRepository(IMapper mapper, DataContex context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }
           public async Task<List<GetMediaDto>> GetAllMedia(bool isSeries)
        {
            var result = new List<GetMediaDto>();

            var medias = await _context.Medias.Include(x => x.Ratings).Include(x => x.Actors).AsSplitQuery().Where(x => x.isSeries == isSeries).OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToListAsync();

            result = medias.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();
            return result;
        }


        
        public async Task<GetMediaDto> GetMedia(int Id)
        {
            var result = new GetMediaDto();

            var media = await _context.Medias
                .Include(x => x.Ratings).AsSplitQuery()
                .Include(x => x.Actors).AsSplitQuery()
                .FirstOrDefaultAsync(x => x.Id == Id);

           result = _mapper.Map<GetMediaDto>(media);
            return result;
        }


        public async Task<List<GetMediaDto>> GetTop10Medias(bool isSeries)
        {
            var result = new List<GetMediaDto>();

            var Top10Movies = await _context.Medias.Include(x => x.Ratings).AsSplitQuery().Where(x => x.isSeries == isSeries).Take(10).ToListAsync();

            var dtoMovies = Top10Movies.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();

            dtoMovies = dtoMovies.OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();

            result = dtoMovies;

            return result;
        }

    }
}