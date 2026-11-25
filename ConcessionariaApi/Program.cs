using ConcessionariaApi.Contexts;
using ConcessionariaApi.Interfaces;
using ConcessionariaApi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ConcessionariaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Concessionaria")));

builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();

builder.Services.AddControllers(o =>
    o.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapGet("/teste/veiculos", (ConcessionariaContext db) => db.Veiculo.ToList());

app.Run();
