using AutoMapper;
namespace Asp.net_Core_WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //to map we use CreateMap
            //CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDto>();

            //Before it creates first it checks , it recursively maps nested objects but both mapping should exist
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Department, DepartmentDto>();

            //for mapping complex object with normal property
            CreateMap<Employee , EmployeeDto>().ForMember(dest => dest.Department , opt=> opt.MapFrom(s=>s.Department.DepartmentName));
        }
    }
}
