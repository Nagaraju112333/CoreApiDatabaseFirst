using CoreDataBaseFirstApproach22.ArchenstModels;
using CoreDataBaseFirstApproach22.Models;
using CoreDataBaseFirstApproach22.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(x =>
{
   x.AutomaticValidationEnabled
    = true;
});

builder.Services.AddTransient<IValidator<UserLogin>, UserValidation>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<venkatContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Muconnection")));
builder.Services.AddDbContext<ArchentsContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ArchenstDbConnection")));
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
