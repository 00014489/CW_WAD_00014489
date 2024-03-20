using CW_MovieApp.Data;
using Microsoft.EntityFrameworkCore;
using CW_MovieApp.Controllers;
using CW_MovieApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MoviesListDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesListConnectionStr")));
builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();
builder.Services.AddScoped<IActorsRepository, ActorsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
