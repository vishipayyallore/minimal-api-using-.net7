using Microsoft.EntityFrameworkCore;
using School.API.Configuration;
using School.ApplicationCore.Interfaces;
using School.Business;
using School.Persistence;
using School.Repositories;
using static School.ApplicationCore.Common.Constants;

namespace School.API.Extensions;

public static class ApplicationServicesExtensions
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        _ = services.AddDbContext<SchoolDbContext>(options => options.UseInMemoryDatabase(InMemoryDatabase.Name));

        _ = services.AddAutoMapper(typeof(AutoMapperConfig));

        _ = services.AddScoped<ICoursesBusiness, CoursesBusiness>();

        _ = services.AddScoped<ICoursesRepository, CoursesRepository>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _ = services.AddEndpointsApiExplorer();
        _ = services.AddSwaggerGen();

        _ = services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy => policy.AllowAnyHeader()
                                                            .WithOrigins("http://localhost:4007")
                                                            .AllowAnyMethod());
        });

        return services;
    }
}
