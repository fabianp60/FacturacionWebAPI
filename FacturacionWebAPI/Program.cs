using Facturacion.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Obtenemos la cadena de conexion del archivo de configuración
string connStr = builder.Configuration.GetConnectionString("cnFacturacion");

// Agregamos la inyección de dependencias de la conexion a SQL Server para BD
builder.Services.AddSqlServer<FacturacionDBContext>(connStr);

var app = builder.Build();

// Ejecutar la migracion para que se acualice o cree la BD
// En la consola del administrador de paquetes, seleccionando el DAL como predeterminado
// ejecuta la siguiente linea para crear la primera migracion
// Add-Migration InitialDB
using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<FacturacionDBContext>();
    ctx.Database.EnsureCreated();
}

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
