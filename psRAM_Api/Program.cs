using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using psRAM_Api;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Application.Interfaces.IServices.IArtefactos;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Application.Services.AnalisisServices;
using psRAM_Application.Services.ArtefactosServices;
using psRAM_Application.Services.SeguridadServices;
using psRAM_Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Conexión a la base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔹 Inyección de dependencias
builder.Services.AddScoped<IApplicationDbContext>(provider =>
{
    var dbContext = provider.GetService<ApplicationDbContext>();
    if (dbContext is null)
    {
        throw new InvalidOperationException("ApplicationDbContext is not registered in the DI container.");
    }
    return dbContext;
});

// --- Servicios de Análisis ---
builder.Services.AddScoped<IResultadoAnalisisService, ResultadoAnalisisService>();
builder.Services.AddScoped<IPuglinEjecutadoService, PuglinEjecutadoService>();
builder.Services.AddScoped<IExportacionService, ExportacionService>();
builder.Services.AddScoped<IImagenMemoriaService, ImagenMemoriaService>();

// --- Servicios de Artefactos ---
builder.Services.AddScoped<IArchivoService, ArchivoService>();
builder.Services.AddScoped<IProcesoService, ProcesoService>();

// --- Servicios de Seguridad ---
builder.Services.AddScoped<IRisKcoreService, RiskScoreService>();

// 🔹 Configuración de API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// --connsulta api Python---
builder.Services.AddHttpClient<IPythonAnalisisService, PythonAnalisisService>();

var app = builder.Build();

// 🔹 Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwagger();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
