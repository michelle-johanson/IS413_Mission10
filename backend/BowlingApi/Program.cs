using BowlingApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddDbContext<BowlingDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BowlingConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.WithOrigins("http://localhost:3000"));
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
