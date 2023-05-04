using CursosAPI.Data.Context;
using CursosAPI.Repositories.Interface;
using CursosAPI.Repositories.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string strConnection = builder.Configuration.GetConnectionString("DefaulConnection");

builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(strConnection);
});

builder.Services.AddScoped<ICursos, CursosRepository>();

builder.Services.AddControllers();
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
