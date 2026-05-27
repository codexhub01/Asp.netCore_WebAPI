using AutoMapper
namespace Asp.net_Core_WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //to map we use CreateMap
            //CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDto>();
        }
    }
}
