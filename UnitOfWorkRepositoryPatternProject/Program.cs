using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPatternProject.Infrastructure;
using UnitOfWorkRepositoryPatternProject.Infrastructure.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddService();
// Add services for configuration of DBConext
builder.Services.AddDbContext<DbContextClass>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

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
