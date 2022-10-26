using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swiggy_API.Core.IServices;
using Swiggy_API.Core.Services;
using Swiggy_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SwiggyDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));
builder.Services.AddScoped<IRegistrationServices, RegistrationServices>();
builder.Services.AddScoped<IProductServices, ProductServices>();
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
