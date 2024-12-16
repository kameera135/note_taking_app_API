using Microsoft.EntityFrameworkCore;
using Note_APP.Interfaces;
using Note_APP.Models;
using Note_APP.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//database service
builder.Services.AddDbContextFactory<NotesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NoteDB")));

builder.Services.AddScoped<INotesRepository, NotesRepository>();

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
