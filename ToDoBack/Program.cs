using Microsoft.EntityFrameworkCore;
using ToDoBack.Data;
using ToDoBack.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region repositories and dbsetting

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("MyAppCs")
));

#endregion

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("corsapp");
app.UseAuthorization();
app.MapControllers();
app.Run();
