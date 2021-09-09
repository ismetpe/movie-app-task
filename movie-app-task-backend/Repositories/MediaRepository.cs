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
            var serviceResponse =  new List<GetMediaDto>();

            var medias = await _context.Medias.Include(x => x.Rating)
                                                 .AsSplitQuery()
                                                 .Where(x => x.isSeries == isSeries)
                                                 .ToListAsync();

            serviceResponse = medias.Select(x => _mapper.Map<GetMediaDto>(x)).ToList();
            return serviceResponse;
        }
    }
}