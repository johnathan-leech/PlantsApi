#region global

global using Microsoft.EntityFrameworkCore;
global using PlantsApi.Models;
global using PlantsApi.Data;
global using System.ComponentModel.DataAnnotations;
#endregion

#region local

using PlantsApi.Services.PlantService;
#endregion

var builder = WebApplication.CreateBuilder(args);

#region services

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IPlantService, PlantService>();
#endregion

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