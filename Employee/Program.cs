using Microsoft.EntityFrameworkCore;
using Employee.DAL;
using Employee.Service.ServicesWireup;
using Employee.Service.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionStrings = builder.Configuration.GetConnectionString("DatabaseConnection");
builder.Services.AddDbContext<EmployeeServiceContext>(options => options.UseSqlServer(connectionStrings));
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.RegisterDependencies();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.AllowAnyOrigin();
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
