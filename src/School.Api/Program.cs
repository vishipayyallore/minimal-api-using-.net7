using Microsoft.EntityFrameworkCore;
using School.API.Extensions;
using School.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureApplicationServices();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("StudentDbConnection");
builder.Services.AddDbContext<SchoolDbContext>(options =>
{
    // const string connectionString = "name=StudentDbConnection"; /* This will also read from appsettings.json */
    _ = options.UseSqlServer(connectionString);
});

var app = builder.Build();

app.ConfigureHttpRequestPipeline();

app.Run();
