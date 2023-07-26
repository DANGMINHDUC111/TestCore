using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiCore.Data;
using WebApiCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MyDbContext>(option =>
{
    option.UseNpgsql(builder.Configuration.GetConnectionString("default"));
});

builder.Services.AddScoped<ILoaiRepo, LoaiRepo>();
builder.Services.AddScoped<IHangHoaRepo, HangHoaRepo>();
builder.Services.AddAuthentication();

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
