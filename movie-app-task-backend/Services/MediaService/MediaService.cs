using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;
using movie_app_task_backend.Models;

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

            var allMoviesdto=( (await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .Take(10)
            .ToListAsync())
            .Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allMoviesdto;
            return result;
        }

        public async Task<List<GetMediaDto>> Get10Series(bool isSeries)
        {
          var result = new List<GetMediaDto>();

            var allSeriesdto=( (await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .Take(10)
            .ToListAsync())
            .Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allSeriesdto;
            return result;
        }

        public async Task<List<GetMediaDto>> GetAllMovies(bool isSeries)
        {
                   var result = new List<GetMediaDto>();
            var allMoviesdto=( (await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .ToListAsync())
            .Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allMoviesdto;
            return result;
        }

        public async Task<List<GetMediaDto>> GetAllSeries(bool isSeries)
        {
            var result = new List<GetMediaDto>();

            var allSeriesdto=( (await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .ToListAsync())
            .Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allSeriesdto;
            return result;
        }

      public async Task<List<GetMediaDto>> Search(string value)
        {
/*
                var result = new List<GetMediaDto>();
                var helper = Regex.Split(value, @"\s+").ToList();
             
    if (!String.IsNullOrEmpty(value))
    {     
          result = await (await _context.Medias.Include(x => x.Ratings).AsSplitQuery().Include(x => x.Actors).AsSplitQuery().Where(s => s.Title.ToUpper().Contains(value.ToUpper()) || s.Description.ToUpper().Contains(value.ToUpper())).ToListAsync()).ToListAsync();
    
                     
    }

          

    return result
    */
    throw new NotImplementedException();
        }
        
    }
}