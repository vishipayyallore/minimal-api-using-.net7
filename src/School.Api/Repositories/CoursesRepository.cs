﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using School.API.ApplicationCore.Interfaces;
using School.API.Data.Dtos;
using School.API.Persistence;

namespace School.API.Repositories;

public class CoursesRepository : ICoursesRepository
{
    private readonly SchoolDbContext _schoolDbContext;
    private readonly IMapper _mapper;
    private readonly ILogger<CoursesRepository> _logger;

    public CoursesRepository(SchoolDbContext schoolDbContext, IMapper mapper, ILogger<CoursesRepository> logger)
    {
        _schoolDbContext = schoolDbContext ?? throw new ArgumentNullException(nameof(schoolDbContext));

        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<IReadOnlyCollection<CourseDto>> GetAllCourses()
    {
        _logger.LogInformation($"Starting CoursesRepository::GetAllCourses()");

        return _mapper.Map<IReadOnlyCollection<CourseDto>>(await _schoolDbContext.Courses.ToListAsync());
    }

}
