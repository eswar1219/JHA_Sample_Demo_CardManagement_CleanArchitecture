
using JHA_Core.Repositories;
using JHA_Core.Repositories.Base;
using JHA_Infrastructure.Data;
using JHA_Infrastructure.Repositories;
using JHA_Infrastructure.Repositories.Base;
using Microsoft.OpenApi.Models;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using JHA_Application.Handlers.CommandHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CardManagementContext>(m => m.UseSqlServer(builder.Configuration.GetConnectionString("CardManagementDB")));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Employee.API",
        Version = "v1"
    });
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddAutoMapper(typeof(Program));

//builder.Services.AddMediatR(typeof(Program));

builder.Services.AddMediatR(typeof(CreateCardHandler).GetTypeInfo().Assembly);

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<ICardRepository, CardRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
