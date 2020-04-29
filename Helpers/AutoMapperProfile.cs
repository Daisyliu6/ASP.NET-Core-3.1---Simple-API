// The automapper profile contains the mapping configuration used by 
// the application, AutoMapper is a package available on Nuget that 
// enables automatic mapping of one type of classes to another
using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Users;

namespace WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}