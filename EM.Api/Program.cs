using EM.Data;
using EM.Domain.Interfaces;
using EM.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string dbPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"../", "BP.Data", "em-database.db"));

builder.Services.AddDbContext<EMContext>(options =>
    options.UseSqlite($"Filename={dbPath}", options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IEmployeesService, EmployeesService>();
builder.Services.AddScoped<IDepartmetsService, DepartmetsService>();
builder.Services.AddScoped<ITasksSerevice, TasksSerevice>();
builder.Services.AddScoped<IReportsSrvice, ReportsSrvice>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
