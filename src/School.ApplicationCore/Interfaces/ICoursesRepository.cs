﻿using School.API.Data.Dtos;

namespace School.API.ApplicationCore.Interfaces;

public interface ICoursesRepository
{
    Task<IReadOnlyCollection<CourseDto>> GetAllCourses();
}