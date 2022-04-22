using Illion0.Context;
using Illion0.ServiceExtension;
using Illion0.Services.background;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


IConfiguration _configaration = builder.Configuration;
// Add services to the container.
builder.Services.AddSingleton<dapperContext>();
builder.Services.AddDbContext<IllionDBContext>(opt => opt.UseSqlServer(_configaration.GetConnectionString("sqlConn")));
builder.Services.AddConfig(_configaration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHostedService<workservice>();

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
