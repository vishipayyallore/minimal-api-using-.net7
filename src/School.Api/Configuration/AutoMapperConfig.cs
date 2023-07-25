using AutoMapper;
using School.Data.Dtos;
using School.Data.Entities;

namespace School.API.Configuration;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        _ = CreateMap<Course, CourseDto>().ReverseMap();

        _ = CreateMap<Course, CreateCourseDto>().ReverseMap();
    }
}