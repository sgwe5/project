using FilmLib.App.services;
using filmsql;
using FlmLib.DataAcces.FilmRepos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FilmLibDb>(
    options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(FilmLibDb)));
    });

builder.Services.AddScoped<IFilmsService, FilmsService>();
builder.Services.AddScoped<IFilmsRepos, FilmsRepos>();
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
