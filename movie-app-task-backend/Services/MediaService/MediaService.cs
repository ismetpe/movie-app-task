using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace movie_app_task_backend.Services.MediaService
{
    public class MediaService : IMediaService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MediaService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<GetMediaDto>> Get10Movies(bool isSeries)
        {
                       var result = new List<GetMediaDto>();

            var allMovies = await _context.Medias.Include(x => x.Ratings).AsSplitQuery().Include(x => x.Actors).AsSplitQuery().Where(x => x.isSeries == isSeries).Take(10).ToListAsync();

            var allMoviesdto = allMovies.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();
            allMoviesdto = allMoviesdto.OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            
            result = allMoviesdto;
            return result;
        }

        public async Task<List<GetMediaDto>> Get10Series(bool isSeries)
        {
          var result = new List<GetMediaDto>();

            var allSeries= await _context.Medias.Include(x => x.Ratings).AsSplitQuery().Include(x => x.Actors).AsSplitQuery().Where(x => x.isSeries == isSeries).Take(10).ToListAsync();

            var allSeriesdto = allSeries.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();
            allSeriesdto = allSeriesdto.OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            
            result = allSeriesdto;
            return result;
        }

        public async Task<List<GetMediaDto>> GetAllMovies(bool isSeries)
        {
                   var result = new List<GetMediaDto>();

            var allMovies = await _context.Medias.Include(x => x.Ratings).AsSplitQuery().Include(x => x.Actors).AsSplitQuery().Where(x => x.isSeries == isSeries).ToListAsync();

            var allMoviesdto = allMovies.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();
            allMoviesdto = allMoviesdto.OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            
            result = allMoviesdto;
            return result;
        }

        public async Task<List<GetMediaDto>> GetAllSeries(bool isSeries)
        {
            var result = new List<GetMediaDto>();

            var allSeries= await _context.Medias.Include(x => x.Ratings).AsSplitQuery().Include(x => x.Actors).AsSplitQuery().Where(x => x.isSeries == isSeries).ToListAsync();

            var allSeriesdto = allSeries.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();
            allSeriesdto = allSeriesdto.OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            
            result = allSeriesdto;
            return result;
        }
    }
}