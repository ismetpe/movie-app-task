using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
using movie_app_task_backend.Repositories;

namespace movie_app_task_backend.Services.MediaService
{
    public class MediaService : IMediaService
    {
  


public readonly MediaRepository _mediaRepository;
        

        public  Task<List<GetMediaDto>> GetAllMedia(bool isSeries)
        {
            return  _mediaRepository.GetAllMedia(isSeries);
        }

        public Task<GetMediaDto> GetMedia(int Id)
        {
            throw new System.NotImplementedException();
        }


        public Task<List<GetMediaDto>> GetTop10Medias(bool isSeries)
        {
            throw new System.NotImplementedException();
        }


    }
}