using Microsoft.EntityFrameworkCore;
using Models.DataBase;
using Models.Interfaces;
using Services.Clients;
using Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// di para tempo de vida do db context
// builder.Services.AddSingleton<UndergroundDbContext>();

// configuaração para o acesso ao banco de dados sql server por meio de 
// injecao de dependencia
var sqlCnn = builder.Configuration.GetConnectionString("underground");
    builder.Services.AddDbContext<UndergroundDbContext>(options =>
        options.UseSqlServer(sqlCnn)
            .EnableDetailedErrors()
            .EnableSensitiveDataLogging()
            .EnableThreadSafetyChecks()
        );

// DI PARA O CICLIO DE VIDA DO HOSPITAL
builder.Services.AddTransient<IHospital, HospitalRepo>();
builder.Services.AddScoped(typeof(HospitalClient), typeof(HospitalClient));

// DI PARA O MEDICO

// DI PARA O TECNICO

//DI PARA O PEDIDO
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
