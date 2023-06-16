using Microsoft.EntityFrameworkCore;
using Models.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// di para tempo de vida do db context
// builder.Services.AddSingleton<UndergroundDbContext>();

var sqlCnn = builder.Configuration.GetConnectionString("underground");
    builder.Services.AddDbContext<UndergroundDbContext>(options =>
        options.UseSqlServer(sqlCnn)
            .EnableDetailedErrors()
            .EnableSensitiveDataLogging()
            .EnableThreadSafetyChecks()
        );

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
