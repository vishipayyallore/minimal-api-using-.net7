﻿namespace School.API.ApplicationCore.Interfaces;

public interface ICoursesBusiness
{
    Task<ApiResponseDto<IReadOnlyCollection<CourseDto>>> GetAllCourses();
}

