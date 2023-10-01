using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data;
using SistemasTarefas.Repositorios;
using SistemasTarefas.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuarioRepositorios, UsuarioRepositorios>();

builder.Services.AddDbContext<UsuariosDbContext>(options =>
    options.UseNpgsql("Host=localhost;Username=postgres;Password=12345;Database=eecomerce"));

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

