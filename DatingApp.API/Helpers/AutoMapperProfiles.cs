using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.DTO;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>().ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                }).ForMember(dest => dest.Age, opt => opt.ResolveUsing(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailDto>().ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            }).ForMember(dest => dest.Age, opt => opt.ResolveUsing(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoForDetailDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotosForCreationDto, Photo>();
        }
    }
}
