using AutoMapper;
using School.API.Data.Dtos;
using School.API.Data.Entities;

namespace School.API.Configuration;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        _ = CreateMap<Course, CourseDto>().ReverseMap();

        _ = CreateMap<Course, CreateCourseDto>().ReverseMap();
    }
}