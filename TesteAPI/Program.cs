using System.Numerics;
using TesteAPI.Services;
using TesteAPI;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IIntegracoes, IntegracoesServices>();


//builder.Services.AddDbContext<RadarDataContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("stringConnection")));



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
