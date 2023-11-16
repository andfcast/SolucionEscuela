using EscuelaBL.Implementacion;
using EscuelaBL.Interfaces;
using EscuelaDAL.Implementacion;
using EscuelaDAL.Interfaces;
using EscuelaEntities.DBEntities;
using EscuelaEntities.DTO;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                      });
});
builder.Services.AddDbContext<EscuelaBDContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EscuelaDBConnection")));

builder.Services.AddTransient<IEntidadBL<EstudianteDto>, EstudianteBL>();
builder.Services.AddTransient<IEntidadDAL<EstudianteDto>, EstudianteDAL>();
builder.Services.AddTransient<IEntidadBL<ProfesorDto>, ProfesorBL>();
builder.Services.AddTransient<IEntidadDAL<ProfesorDto>, ProfesorDAL>();
builder.Services.AddTransient<IEntidadBL<NotaDto>, NotaBL>();
builder.Services.AddTransient<IEntidadDAL<NotaDto>, NotaDAL>();
builder.Services.AddTransient<IEstudianteBL, EstudianteBL>();
builder.Services.AddTransient<IEstudianteDAL, EstudianteDAL>();
builder.Services.AddTransient<IProfesorBL, ProfesorBL>();
builder.Services.AddTransient<IProfesorDAL, ProfesorDAL>();
builder.Services.AddTransient<INotaBL, NotaBL>();
builder.Services.AddTransient<INotaDAL, NotaDAL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
