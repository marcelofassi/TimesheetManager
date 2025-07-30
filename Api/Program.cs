using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TimesheetApi.Application.Services;
using TimesheetApi.Application.Validators;
using TimesheetApi.Domain;


var builder = WebApplication.CreateBuilder(args);



// Servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<ProyectoDtoValidator>();


// Registro del DbContext
builder.Services.AddDbContext<DvrTimeSheetContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ProyectoService>();
builder.Services.AddScoped<ActividadeService>();
builder.Services.AddScoped<ActividadesEstadoService>();
builder.Services.AddScoped<AdjuntoService>();
builder.Services.AddScoped<AdjuntosActividadeService>();
builder.Services.AddScoped<CargaHorariumService>();
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddScoped<CierreMeService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ConfiguracioneService>();
builder.Services.AddScoped<CostoRecursoService>();
builder.Services.AddScoped<EstadosDeActividadeService>();
builder.Services.AddScoped<EstadosRecursoService>();
builder.Services.AddScoped<FechasHitoService>();
builder.Services.AddScoped<FeriadoService>();
builder.Services.AddScoped<HitoService>();
builder.Services.AddScoped<HojaDeTiempoService>();
builder.Services.AddScoped<JornadaService>();
builder.Services.AddScoped<PaiService>();
builder.Services.AddScoped<PresupuestoMesProyectoService>();
builder.Services.AddScoped<ProyectosTecnologiaService>();
builder.Services.AddScoped<RecursoCategoriumService>();
builder.Services.AddScoped<RecursoService>();
builder.Services.AddScoped<RecursoTecnologiumService>();
builder.Services.AddScoped<ResourceToActivityService>();
builder.Services.AddScoped<ResourceToProjectService>();
builder.Services.AddScoped<TecnologiaService>();
builder.Services.AddScoped<UbicacionOficinasDiveriumService>();
builder.Services.AddScoped<UbicacioneService>();
builder.Services.AddScoped<UserService>();


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
